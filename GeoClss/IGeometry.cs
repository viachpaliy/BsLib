using System;
using System.Collections;
using BsEnums;

namespace  GeoClss
{

public interface IGeometry : IEnumerable
{

	int Count
	{
		get;
	}


	int Side
	{
		get;

		set;
	}

	int Corner
	{
		get;

		set;
	}

	int ID
	{
		get;

		set;
	}

	EN_CLSS_GEODIR Dir
	{
		get;

		set;
	}


	EN_CLSS_ON_OFF Degenerated
	{
		get;

		set;
	}


	IEnumerator GetEnumerator();

	IGeoElement Item(int nIndex);

	void Add( IGeoElement pObject, string Key = "" );

	void Remove(int nIndex);

	void RemoveAll();

	Geometry CreateCopy();

	void Traslate2D(double dX, double dY);

	EN_CLSS_GEO_PROPERTY IsOpen();
	
	void Traslate3D(double dX, double dY, double dZ);

	void GetBoundCoordinates(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin);

	void MirrorX(double dAxis, EN_CLSS_ON_OFF nMirrorNv);

	void MirrorY(double dAxis, EN_CLSS_ON_OFF nMirrorNv);

	void GetStartEndPoints(out double dXS, out double dYS, out double dZS, out double dXE, out double dYE, out double dZE);

	double GetLength(out int nError);

	void GetStartEndNv(ref double dXSNv, ref double dYSNv, ref double dZSNv, ref double dXENv, ref double dYENv, ref double dZENv);

	void ReferTo(int nNewCorner, double dWidth, double dHeight, EN_CLSS_ON_OFF nUseOnlyCWCCW);
	
	void GetStartPoint(out double dX, out double dY, out double dZ);

	void GetEndPoint(out double dX, out double dY, out double dZ);

	void GetStartNv(out double dX, out double dY, out double dZ);

	void GetEndNv(out double dX, out double dY, out double dZ);

	void Trace();

	void Rotate3D(double dOrigX, double dOrigY, double dOrigZ, double dAxisX, double dAxisY, double dAxisZ, double dRotAngle, EN_CLSS_ON_OFF nRotNv);

	void Reverse(EN_CLSS_ON_OFF nReverseLayer, EN_CLSS_ON_OFF nKeepSameStartNv);
	
	EN_CLSS_RETURN_CODE IsValid(EN_CLSS_ON_OFF nOkIfConnected);
	   
	void SetStartNv(double dX, double dY, double dZ);
	
	void SetEndNv(double dX, double dY, double dZ);

	void SetStartEndNv(double dXSNv, double dYSNv, double dZSNv, double dXENv, double dYENv, double dZENv);
	
	void SetSameNvToAll(double dX, double dY, double dZ, EN_CLSS_ON_OFF nAlsoCenterNv);
	
	void SwapXY();

	EN_CLSS_ON_OFF GetWaitMirrorX();

	EN_CLSS_ON_OFF GetWaitMirrorY();

	double GetWaitDiscreteRotationAngle();

	double GetWaitRotationAngle();

	void PutWaitMirrorX(EN_CLSS_ON_OFF nVal);

	void PutWaitMirrorY(EN_CLSS_ON_OFF nVal);
	
	void PutWaitDiscreteRotationAngle(double dVal);
	
	void PutWaitRotationAngle(double dVal);
	
	void InitWaitData(EN_CLSS_ON_OFF nMirrorX, EN_CLSS_ON_OFF nMirrorY, double dRotAngle);
	
	void UpdateWaitData(EN_CLSS_ON_OFF nMirrorX, EN_CLSS_ON_OFF nMirrorY, double dRotAngle);
	
	int GetDualCorner(double dAngZ);
	
	void AppendGeometry(EN_CLSS_ON_OFF nCopy, EN_CLSS_ON_OFF nCopyPoints, Geometry pGeometry);
	
	void SameRelativeNvDirection();

	void Scale(double dScaleFactor);
	
	void Discretize(double dMaxSegmentLength, EN_CLSS_ON_OFF nDecomposeAlsoLines, out EN_CLSS_ON_OFF nBadDiscretiz);
	
	void FilterLayer(int nLayersToRemove, EN_CLSS_ON_OFF nFilterAlsoVerticalLines);
	
	void ChangeOrder();

	void ReverseBetweenReposition(EN_CLSS_ON_OFF nReverseLayer, EN_CLSS_ON_OFF nKeepSameStartNv);
	
	int GetDirectionAndArea(double dFaceLength, double dFaceHeight, out EN_CLSS_ARCDIR nDir, out double dArea);
	
	int GetSharpCorners(double dDeltaIn, double dDeltaOut, out Geometries pGeometries);
	
	int AddLinearInOutOnSharpCorners(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning, EN_CLSS_ON_OFF nAlsoOnExtemes);
	
	int AddLinearInOutOnExtremes(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning);

	int ExtractTangentSubGeometry(int nRefElementID, out Geometry pSubGeometry, out IGeoElement pPreviousElement, out IGeoElement pFollowingElement, double vTangentPrecision);
	
	int DivideIntoTangentGeometries(out Geometries pTangentGeometries, out Geometry pPreviousElements, out Geometry pFollowingElemnts, double vTangentPrecision);
	
	int FindItemByID(int nID, int nStart);
	
	int ExtendGeometry(double dStartExtension, double dEndExtension);

	int ZoomCorner(double dFirstElementZoom, double dSecondElementZoom, EN_CLSS_ON_OFF nRightZoom, EN_CLSS_ON_OFF nKeepElementsLength, double dStandardRoundingRadius, double dDeltaIn, double dDeltaOut, double dDeltaRoundingRadius);

	int Intersection(GELine pLine, EN_CLSS_ON_OFF nReverse, EN_CLSS_ON_OFF nRightCorr, out double dX, out double dY, out double dZ);

	void ResetGeometryIDs();

	int SmoothByAddingArcs(double dArcRadius, double vTangentPrecision);
	
	int AddLinearExtensions(double dStartExtension, double dEndExtension);

	short JoinByExtend(Geometries pGeometriesToJoin, EN_CLSS_ON_OFF nAlsoStartEnd);
	
	//int RelocateInterventions(Geometry pOriginalGeometry, Technologies pInterventions, EN_CLSS_TDC_TC nCorrection, out int nBadInterventionID);
	
	int GetPointFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ);
	
	int GetTangentFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ);
	
	int Intersect(IGeoElement pGeoElement, EN_CLSS_ON_OFF nExtend1, EN_CLSS_ON_OFF nExtend2, out Geometry pSolutions, out IEnumerable arrIndex);
	
	void GetDistanceFromPoint(EN_CLSS_POINT nRefPoint, double dX, double dY, double dZ, ref double dDistance, ref int nError);
	
	void TraceSubIDs();

	void TraceInterventions();

	int ExtractSubGeometryLyingUnder(double dSeparationQuote, out Geometries pTangentGeometries);

	int TurnTo2D(int nDiscretize3DArcs, double dDiscrLength);
	
	int Explode();

	double Distance(IGeoElement pGeoElement);
	
	int AppendNotEqualPointFromGeometry(Geometry pGeometry);

	void Append(Geometry pSrc);
	
	int IntersectGeometry(Geometry pGeometry);
	
	void ChangeOrigin(double lpx, double lpy, double lpz, int simm_X, int simm_Y, int trasl_X, int trasl_Y, double orig_X, double orig_Y, int nSide);
	
	int ZoomCornerEx(double dFirstElementZoom, double dSecondElementZoom, EN_CLSS_ON_OFF nRightZoom, EN_CLSS_ON_OFF nKeepElementsLength, double dPreIn, double dPreOut, double dRadius, double dDeltaIn, double dDeltaOut, double dDeltaRoundingRadius);
	
	void CutGeometry(double val, bool percent, EN_CLSS_POINT point, out int pErr);
	
	short GetTypeOfColl();

	short IsTangent(double vTangentPrecision, out Geometry ppPointList);
	
	short IsNonContinousPoint(double dX, double dY, double dZ);
	   
	int GetNonContinousPoints(out Geometry ppPointList);

	EN_CLSS_GEODIR GetTowards();

	void AdjustTangent(double pPrecision);
	
	Geometry GeometryExtension(double val, EN_CLSS_POINT point);
	
	void SetIncrementalDeep(double val, EN_CLSS_POINT point);

	EN_CLSS_GEOELE_TYPE GetEleType(int Index);

	IGeoElement GetFirstNoPoint();

	void SetLayer(EN_CLSS_GEO_LAYER enLayer);

	void DeleteZeroLengthEle(EN_CLSS_ON_OFF enDelStartPoint, object vTrasferisciTechdataElementiNulli);
	
	void Break2Geometries(double dCutLength, EN_CLSS_POINT nUsePoint, out Geometry pGeometry);
	
	short SetTabbingIncrementalDeep(double dDeepDiff, double dHeightTabb, double dLengthTabb, EN_CLSS_POINT nUsePoint);
	
	void Insert(IGeoElement pEle, int Index);

	Geometry From2DTo3D(double dLpx, double dLpy, double dLpz);
	
	EN_CLSS_ON_OFF IsOnlyOneLine();

	int ExplodeAll();

	EN_CLSS_ON_OFF IsOppositDir(IGeoElement pEle);
	
	short IsContinous(out IGeoElement ppGeoElement);
	
	Geometry Compensate(double dVal, EN_CLSS_TDC_TC enTC, short onlyDegen);
  }

}