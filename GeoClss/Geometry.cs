using System;
using System.Collections;
using System.Collections.Generic;
using BsEnums;

namespace  GeoClss
{

public class Geometry : IGeometry
{
    List<IGeoElement> items = new List<IGeoElement>();
    List<string> keys = new List<string>();

	public int Count
	{
		get
        {
            return items.Count;
        }
	}


	public int Side
	{
		get;

		set;
	}

	public int Corner
	{
		get;

		set;
	}

	public int ID
	{
		get;

		set;
	}

	public EN_CLSS_GEODIR Dir
	{
		get;

		set;
	}


	public EN_CLSS_ON_OFF Degenerated
	{
		get;

		set;
	}

    public Geometry(){}

	public IEnumerator GetEnumerator()
    {
        return items.GetEnumerator();
    }

	public IGeoElement Item(int nIndex)
    {
        return items[nIndex];
    }

	public void Add( IGeoElement pObject, string Key = "" )
    {
        items.Add(pObject);
        keys.Add(Key);
    }

	public void Remove(int nIndex)
    {
        items.RemoveAt(nIndex);
        keys.RemoveAt(nIndex);
    }

	public void RemoveAll()
    {
        items.Clear();
        keys.Clear();
    }

    public Geometry(Geometry other)
    {
        foreach (IGeoElement item in other)
        {
            Add(item,"");
        }
        Side = other.Side;
        Corner = other.Corner;
        Dir = other.Dir;
        Degenerated = other.Degenerated;
    }

	public Geometry CreateCopy()
    {
        return new Geometry(this);
    }

	public void Traslate2D(double dX, double dY)
    {
        throw new NotImplementedException();
    }

	public EN_CLSS_GEO_PROPERTY IsOpen()
    {
        EN_CLSS_GEO_PROPERTY result = EN_CLSS_GEO_PROPERTY.CGEO_PROP_OPEN;
        throw new NotImplementedException();
        return result;
    }
	
	public void Traslate3D(double dX, double dY, double dZ)
    {
       throw new NotImplementedException(); 
    }

	public void GetBoundCoordinates(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin)
    {
        throw new NotImplementedException();
    }

	public void MirrorX(double dAxis, EN_CLSS_ON_OFF nMirrorNv)
    {
        throw new NotImplementedException();
    }

	public void MirrorY(double dAxis, EN_CLSS_ON_OFF nMirrorNv)
    {
        throw new NotImplementedException();
    }

	public void GetStartEndPoints(out double dXS, out double dYS, out double dZS, out double dXE, out double dYE, out double dZE)
    {
        throw new NotImplementedException();
    }

	public double GetLength(out int nError)
    {
        double length = 0;
        int error = 0;
        foreach(var item in items)
        {
            length += item.GetLength(out error);
        }
        nError = error;
        return length;
    }


	public void GetStartEndNv(ref double dXSNv, ref double dYSNv, ref double dZSNv, ref double dXENv, ref double dYENv, ref double dZENv)
    {
        throw new NotImplementedException();
    }

	public void ReferTo(int nNewCorner, double dWidth, double dHeight, EN_CLSS_ON_OFF nUseOnlyCWCCW)
    {
        throw new NotImplementedException();
    }
	
	public void GetStartPoint(out double dX, out double dY, out double dZ)
    {
        items[0].GetPoint(EN_CLSS_POINT.CPOINT_START,out dX,out dY,out dZ);
    }
    
	public void GetEndPoint(out double dX, out double dY, out double dZ)
    {
        items[Count - 1].GetPoint(EN_CLSS_POINT.CPOINT_END, out dX, out dY, out dZ);
    }

	public void GetStartNv(out double dX, out double dY, out double dZ)
    {
        dX = 0;
        dY = 0;
        dZ = 0;
        throw new NotImplementedException();
    }

	public void GetEndNv(out double dX, out double dY, out double dZ)
    {
        dX = 0;
        dY = 0;
        dZ = 0;
        throw new NotImplementedException();
    }

	public void Trace()
    {
        throw new NotImplementedException();
    }

	public void Rotate3D(double dOrigX, double dOrigY, double dOrigZ, double dAxisX, double dAxisY, double dAxisZ, double dRotAngle, EN_CLSS_ON_OFF nRotNv)
    {
        foreach(var item in items)
        {
            item.Rotate3D(dOrigX, dOrigY, dOrigZ, dAxisX, dAxisY, dAxisZ, dRotAngle, nRotNv);
        }
    }

	public void Reverse(EN_CLSS_ON_OFF nReverseLayer, EN_CLSS_ON_OFF nKeepSameStartNv)
    {
        throw new NotImplementedException();
    }
	
	public EN_CLSS_RETURN_CODE IsValid(EN_CLSS_ON_OFF nOkIfConnected)
    {
        throw new NotImplementedException();
        return EN_CLSS_RETURN_CODE.CCE_NOT_OK;
    }
	   
	public void SetStartNv(double dX, double dY, double dZ)
    {
        throw new NotImplementedException();
    }
	
	public void SetEndNv(double dX, double dY, double dZ)
    {
        throw new NotImplementedException();
    }

	public void SetStartEndNv(double dXSNv, double dYSNv, double dZSNv, double dXENv, double dYENv, double dZENv)
    {
        throw new NotImplementedException();
    }
	
	public void SetSameNvToAll(double dX, double dY, double dZ, EN_CLSS_ON_OFF nAlsoCenterNv)
    {
        throw new NotImplementedException();
    }
	
	public void SwapXY()
    {
        throw new NotImplementedException();
    }

	public EN_CLSS_ON_OFF GetWaitMirrorX()
    {
        throw new NotImplementedException();
        return EN_CLSS_ON_OFF.CCL_OFF;
    }

	public EN_CLSS_ON_OFF GetWaitMirrorY()
    {
        throw new NotImplementedException();
        return EN_CLSS_ON_OFF.CCL_OFF;
    }

	public double GetWaitDiscreteRotationAngle()
    {
        throw new NotImplementedException();
        return 0.0;
    }

	public double GetWaitRotationAngle()
    {
        throw new NotImplementedException();
        return 0.0;
    }

	public void PutWaitMirrorX(EN_CLSS_ON_OFF nVal)
    {
        throw new NotImplementedException();
    }

	public void PutWaitMirrorY(EN_CLSS_ON_OFF nVal)
    {
        throw new NotImplementedException();
    }
	
	public void PutWaitDiscreteRotationAngle(double dVal)
    {
        throw new NotImplementedException();
    }
	
	public void PutWaitRotationAngle(double dVal)
    {
        throw new NotImplementedException();
    }
	
	public void InitWaitData(EN_CLSS_ON_OFF nMirrorX, EN_CLSS_ON_OFF nMirrorY, double dRotAngle)
    {
        throw new NotImplementedException();
    }
	
	public void UpdateWaitData(EN_CLSS_ON_OFF nMirrorX, EN_CLSS_ON_OFF nMirrorY, double dRotAngle)
    {
        throw new NotImplementedException();
    }
	
	public int GetDualCorner(double dAngZ)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public void AppendGeometry(EN_CLSS_ON_OFF nCopy, EN_CLSS_ON_OFF nCopyPoints, Geometry pGeometry)
    {
        throw new NotImplementedException();
    }
	
	public void SameRelativeNvDirection()
    {
        throw new NotImplementedException();
    }

	public void Scale(double dScaleFactor)
    {
        throw new NotImplementedException();
    }
	
	public void Discretize(double dMaxSegmentLength, EN_CLSS_ON_OFF nDecomposeAlsoLines, out EN_CLSS_ON_OFF nBadDiscretiz)
    {
        nBadDiscretiz = EN_CLSS_ON_OFF.CCL_OFF;
        throw new NotImplementedException();
    }
	
	public void FilterLayer(int nLayersToRemove, EN_CLSS_ON_OFF nFilterAlsoVerticalLines)
    {
        throw new NotImplementedException();
    }
	
	public void ChangeOrder()
    {
        throw new NotImplementedException();
    }

	public void ReverseBetweenReposition(EN_CLSS_ON_OFF nReverseLayer, EN_CLSS_ON_OFF nKeepSameStartNv)
    {
        throw new NotImplementedException();
    }
	
	public int GetDirectionAndArea(double dFaceLength, double dFaceHeight, out EN_CLSS_ARCDIR nDir, out double dArea)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int GetSharpCorners(double dDeltaIn, double dDeltaOut, out Geometries pGeometries)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int AddLinearInOutOnSharpCorners(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning, EN_CLSS_ON_OFF nAlsoOnExtemes)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int AddLinearInOutOnExtremes(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning)
    {
        throw new NotImplementedException();
        return 0;
    }

	public int ExtractTangentSubGeometry(int nRefElementID, out Geometry pSubGeometry, out IGeoElement pPreviousElement, out IGeoElement pFollowingElement, double vTangentPrecision)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int DivideIntoTangentGeometries(out Geometries pTangentGeometries, out Geometry pPreviousElements, out Geometry pFollowingElemnts, double vTangentPrecision)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int FindItemByID(int nID, int nStart)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int ExtendGeometry(double dStartExtension, double dEndExtension)
    {
        throw new NotImplementedException();
        return 0;
    }

	public int ZoomCorner(double dFirstElementZoom, double dSecondElementZoom, EN_CLSS_ON_OFF nRightZoom, EN_CLSS_ON_OFF nKeepElementsLength, double dStandardRoundingRadius, double dDeltaIn, double dDeltaOut, double dDeltaRoundingRadius)
    {
        throw new NotImplementedException();
        return 0;
    }

	public int Intersection(GELine pLine, EN_CLSS_ON_OFF nReverse, EN_CLSS_ON_OFF nRightCorr, out double dX, out double dY, out double dZ)
    {
        throw new NotImplementedException();
        return 0;
    }

	public void ResetGeometryIDs()
    {
        throw new NotImplementedException();
    }

	public int SmoothByAddingArcs(double dArcRadius, double vTangentPrecision)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int AddLinearExtensions(double dStartExtension, double dEndExtension)
    {
        throw new NotImplementedException();
        return 0;
    }

	public short JoinByExtend(Geometries pGeometriesToJoin, EN_CLSS_ON_OFF nAlsoStartEnd)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	//int RelocateInterventions(Geometry pOriginalGeometry, Technologies pInterventions, EN_CLSS_TDC_TC nCorrection, out int nBadInterventionID);
	
	public int GetPointFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int GetTangentFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int Intersect(IGeoElement pGeoElement, EN_CLSS_ON_OFF nExtend1, EN_CLSS_ON_OFF nExtend2, out Geometry pSolutions, out IEnumerable arrIndex)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public void GetDistanceFromPoint(EN_CLSS_POINT nRefPoint, double dX, double dY, double dZ, ref double dDistance, ref int nError)
    {
        throw new NotImplementedException();
    }
	
	public void TraceSubIDs()
    {
        throw new NotImplementedException();
    }

	public void TraceInterventions()
    {
        throw new NotImplementedException();
    }

	public int ExtractSubGeometryLyingUnder(double dSeparationQuote, out Geometries pTangentGeometries)
    {
        throw new NotImplementedException();
        return 0;
    }

	public int TurnTo2D(int nDiscretize3DArcs, double dDiscrLength)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public int Explode()
    {
        throw new NotImplementedException();
        return 0;
    }

	public double Distance(IGeoElement pGeoElement)
    {
        throw new NotImplementedException();
        return 0.0;
    }
	
	public int AppendNotEqualPointFromGeometry(Geometry pGeometry)
    {
        throw new NotImplementedException();
        return 0;
    }

	public void Append(Geometry pSrc)
    {
        throw new NotImplementedException();
    }
	
	public int IntersectGeometry(Geometry pGeometry)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public void ChangeOrigin(double lpx, double lpy, double lpz, int simm_X, int simm_Y, int trasl_X, int trasl_Y, double orig_X, double orig_Y, int nSide)
    {
        throw new NotImplementedException();
    }
	
	public int ZoomCornerEx(double dFirstElementZoom, double dSecondElementZoom, EN_CLSS_ON_OFF nRightZoom, EN_CLSS_ON_OFF nKeepElementsLength, double dPreIn, double dPreOut, double dRadius, double dDeltaIn, double dDeltaOut, double dDeltaRoundingRadius)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public void CutGeometry(double val, bool percent, EN_CLSS_POINT point, out int pErr)
    {
        throw new NotImplementedException();
    }
	
	public short GetTypeOfColl()
    {
        throw new NotImplementedException();
        return 0;
    }

	public short IsTangent(double vTangentPrecision, out Geometry ppPointList)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public short IsNonContinousPoint(double dX, double dY, double dZ)
    {
        throw new NotImplementedException();
        return 0;
    }
	   
	public int GetNonContinousPoints(out Geometry ppPointList)
    {
        throw new NotImplementedException();
        return 0;
    }

	public EN_CLSS_GEODIR GetTowards()
    {
        throw new NotImplementedException();
        return EN_CLSS_GEODIR.CGEODIR_UNKNOWN;
    }
   
	public void AdjustTangent(double pPrecision)
    {
        throw new NotImplementedException();
    }
	
	public Geometry GeometryExtension(double val, EN_CLSS_POINT point)
    {
        throw new NotImplementedException();
        return new Geometry();
    }
	
	public void SetIncrementalDeep(double val, EN_CLSS_POINT point)
    {
        throw new NotImplementedException();
    }

	public EN_CLSS_GEOELE_TYPE GetEleType(int Index)
    {
        return items[Index].GeoType;
    }

	public IGeoElement GetFirstNoPoint()
    {
        IGeoElement result = items[0];
        foreach(IGeoElement item in items)
        {
            if (item.GeoType != EN_CLSS_GEOELE_TYPE.CGT_POINT) 
            {
                return item;
            }
        }
        return result;
    }

	public void SetLayer(EN_CLSS_GEO_LAYER enLayer)
    {
        throw new NotImplementedException();
    }

	public void DeleteZeroLengthEle(EN_CLSS_ON_OFF enDelStartPoint, object vTrasferisciTechdataElementiNulli)
    {
        throw new NotImplementedException();
    }
	
	public void Break2Geometries(double dCutLength, EN_CLSS_POINT nUsePoint, out Geometry pGeometry)
    {
        throw new NotImplementedException();
    }
	
	public short SetTabbingIncrementalDeep(double dDeepDiff, double dHeightTabb, double dLengthTabb, EN_CLSS_POINT nUsePoint)
    {
        throw new NotImplementedException();
        return 0;
    }
	
	public void Insert(IGeoElement pEle, int Index)
    {
        throw new NotImplementedException();
    }

	public Geometry From2DTo3D(double dLpx, double dLpy, double dLpz)
    {
        throw new NotImplementedException();
        return new Geometry();
    }
	
	public EN_CLSS_ON_OFF IsOnlyOneLine()
    {
        if ((Count == 1) && (items[0].GeoType == EN_CLSS_GEOELE_TYPE.CGT_LINE))
        {
            return EN_CLSS_ON_OFF.CCL_ON;
        }
        return EN_CLSS_ON_OFF.CCL_OFF;
    }

	public int ExplodeAll()
    {
        throw new NotImplementedException();
        return 0;
    }

	public EN_CLSS_ON_OFF IsOppositDir(IGeoElement pEle)
    {
        throw new NotImplementedException();
        return EN_CLSS_ON_OFF.CCL_OFF;
    }
	
	public short IsContinous(out IGeoElement ppGeoElement)
    {
        throw new NotImplementedException();
        return 0;
    }
    	
	public Geometry Compensate(double dVal, EN_CLSS_TDC_TC enTC, short onlyDegen)
    {
        throw new NotImplementedException();
        return new Geometry();
    }
  }

}