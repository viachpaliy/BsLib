using System;
using System.Collections;
using BsEnums;

namespace  GeoClss
{
  public class GELine : IGeoElement
  {
    public EN_CLSS_GEOELE_TYPE GeoType
	{
		get
        {return EN_CLSS_GEOELE_TYPE.CGT_LINE ;}
	}

    public int PLineID
	{
		get;

		set;
	}

	public EN_CLSS_GEO_LAYER Layer
	{
		get;

		set;
	}

	public EN_CLSS_ON_OFF PassThrough
	{
		get;

		set;
	}

	public double XStart
	{
		get;

		set;
	}

	public double YStart
	{
		get;

		set;
	}

	public double ZStart
	{
		get;

		set;
	}

	public double XEnd
	{
		get;

		set;
	}

	public double YEnd
	{
		get;
	
		set;
	}

	public double ZEnd
	{
		get;
		
		set;
	}

	public GETechData TechData
	{
		get;

		set;
	}

	public EN_CLSS_ON_OFF First
	{
		get;
		
		set;
	}

	public int Color
	{
		get;

		set;
	}

	public int ID
	{
		get;

		set;
	}

	public string DxfLayer
	{
		get;
		
		set;
	}

	public double XMid()
    {
        return (XStart + XEnd)/2;
    }

	public double YMid()
    {
        return (YStart +YEnd)/2;
    }

	public double ZMid()
    {
        return (ZStart + ZEnd)/2;
    }

	public double GetLength(out int nError)
    {
        nError = 0;
        double dX = XEnd - XStart;
        double dY = YEnd - YStart;
        double dZ = ZEnd - ZStart;
        return Math.Sqrt(dX*dX + dY*dY + dZ*dZ);
    }

	public void ChangeLength(double newVal, EN_CLSS_POINT nUsePoint)
    {
        throw new NotImplementedException();
    }

	public double GetAngleR()
    {
        throw new NotImplementedException();
        return -1;
    }

	public double GetAngleZ()
    {
        throw new NotImplementedException();
        return -1;
    }

	public EN_CLSS_RETURN_CODE GetPoint(EN_CLSS_POINT nWhich, out double pdX, out double pdY, out double pdZ)
    {
        throw new NotImplementedException();
	    return EN_CLSS_RETURN_CODE.CCE_NOT_OK ;
    }

	public void GetStartPoint(out double pdX, out double pdY, out double pdZ)
    {
        pdX = XStart;
        pdY = YStart;
        pdZ = ZStart;
    }

	public void GetEndPoint(out double pdX, out double pdY, out double pdZ)
    {
        pdX = XEnd;
        pdY = YEnd;
        pdZ = ZEnd;
    }

	public void SetStartPoint(double dX, double dY, double dZ)
    {
        XStart = dX;
        YStart = dY;
        ZStart = dZ;
    }

	public void SetEndPoint(double dX, double dY, double dZ)
    {
        XEnd = dX;
        YEnd = dY;
        ZEnd = dZ;
    }

	public	void GetStartNv(out double pdX, out double pdY, out double pdZ)
    {
         throw new NotImplementedException();
    }

	public void GetEndNv(out double pdX, out double pdY, out double pdZ)
    {
         throw new NotImplementedException();
    }

	public	void SetStartNv(double dX, double dY, double dZ)
    {
         throw new NotImplementedException();
    }

	public void SetEndNv(double dX, double dY, double dZ)
    {
         throw new NotImplementedException();
    }

	public void ChangeDir(EN_CLSS_ON_OFF nSwapTachData)
    {
         throw new NotImplementedException();
    }

	public void GetMaxMinX(out double dXMax, out double dXMin)
    {
        if (XStart > XEnd)
        {
            dXMax = XStart;
            dXMin = XEnd;
        } else
        {
            dXMax = XEnd;
            dXMin = XStart;
        }
    }

	public	void GetMaxMinY(out double dYMax, out double dYMin)
    {
        if (YStart > YEnd)
        {
            dYMax = YStart;
            dYMin = YEnd;
        } else
        {
            dYMax = YEnd;
            dYMin = YStart;
        }
    }

	public void GetMaxMinZ(out double dZMax, out double dZMin)
    {
        if (ZStart > ZEnd)
        {
            dZMax = ZStart;
            dZMin = ZEnd;
        } else
        {
            dZMax = ZEnd;
            dZMin = ZStart;
        }
    }

	public void Break2Elements(double dDistance, EN_CLSS_POINT nUsePoint, out IGeoElement pGeoEle)
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

	public	void Traslate2D(double dX, double dY)
    {
         throw new NotImplementedException();
    }

	public	void Traslate3D(double dX, double dY, double dZ)
    {
         throw new NotImplementedException();
    }

	public	void ReferTo(int nOldCorner, int nNewCorner, double dWidth, double dHeight)
    {
         throw new NotImplementedException();
    }

	public	void GetDirNv(out double dX, out double dY, out double dZ)
    {
         throw new NotImplementedException();
    }

	public	double DistanceToParallelLine(GELine pLine)
    {
         throw new NotImplementedException();
         return -1;
    }

	public	void GetIntersection(GELine pLine, out EN_CLSS_ON_OFF nExists, out double dX, out double dY, out double dZ)
    {
         throw new NotImplementedException();
    }

	public EN_CLSS_RETURN_CODE IsValid()
    {
         throw new NotImplementedException();
         return EN_CLSS_RETURN_CODE.CCE_NOT_OK ;
    }

	public int ErrorCode()
    {
        throw new NotImplementedException();
        return 0;
    }

	public string GetErrorMessage(int nECode)
    {
        return "Not implemented";
    }

	public	void Scale(double dScaleFactor)
    {
         throw new NotImplementedException();
    }
	
	//public short GetIntersectionWithArc(GEArc pArc, out double dX1, out double dY1, out double dZ1, out double dX2, out double dY2, out double dZ2);

	public	void InitCommonParameters(int nID, EN_CLSS_GEOELE_TYPE nGeoType, EN_CLSS_GEO_LAYER nLayer, EN_CLSS_ON_OFF nPassThrough, EN_CLSS_ON_OFF nFirst, int nColor, GETechData pTechData, string sDxfLayer)
    {
        ID = nID;
        Layer = nLayer;
        PassThrough = nPassThrough;
        First = nFirst;
        Color = nColor;
        TechData = pTechData;
        DxfLayer = sDxfLayer;
    }
	
	public void GetCommonParameters(out int nID, out EN_CLSS_GEOELE_TYPE nGeoType, out EN_CLSS_GEO_LAYER nLayer, out EN_CLSS_ON_OFF nPassThrough, out EN_CLSS_ON_OFF nFirst, out int nColor, out GETechData pTechData, out string pDxfLayer)
    {
        nGeoType = GeoType;
        nID = ID;
        nLayer = Layer;
        nPassThrough = PassThrough;
        nFirst = First;
        nColor = Color;
        pTechData = TechData;
        pDxfLayer = DxfLayer;
    }

	public void SetLineParameters(double dXS, double dYS, double dZS, double dXSNv, double dYSNv, double dZSNv, double dXE, double dYE, double dZE, double dXENv, double dYENv, double dZENv)
    {
         throw new NotImplementedException();
    }

	public void GetLineParameters(out double dXS, out double dYS, out double dZS, out double dXSNv, out double dYSNv, out double dZSNv, out double dXE, out double dYE, out double dZE, out double dXENv, out double dYENv, out double dZENv)
    {
         throw new NotImplementedException();
    }

	
	public void SetStart(double dX, double dY, double dZ, double dXNv, double dYNv, double dZNv)
    {
         throw new NotImplementedException();
    }

	public	void GetStart(out double dX, out double dY, out double dZ, out double dXNv, out double dYNv, out double dZNv)
    {
         throw new NotImplementedException();
    }
	
	public void SetEnd( double dX, double dY,  double dZ, double dXNv, double dYNv, double dZNv)
    {
         throw new NotImplementedException();
    }

	public	void GetEnd(out double dX, out double dY, out double dZ, out double dXNv, out double dYNv, out double dZNv)
    {
         throw new NotImplementedException();
    }

	public	int GetPointFromDistance(double dDistance, EN_CLSS_POINT nUsePoint, out double dX, out double dY, out double dZ)
    {
         throw new NotImplementedException();
         return -1;
    }

	public	int Intersect(IGeoElement pGeoElement, EN_CLSS_ON_OFF nExtend1, EN_CLSS_ON_OFF nExtend2, out Geometry pSolutions)
    {
         throw new NotImplementedException();
         return -1;
    }

	public	int ExtractSubGeometriesLyingUnderAndOver(double dSeparationQuote, out Geometry pUnderGeometry, out Geometry pOverGeometry)
    {
         throw new NotImplementedException();
         return -1;
    }

	public double Distance(IGeoElement pGeoElement)
    {
         throw new NotImplementedException();
         return -1;
    }

    public IGeoElement CreateCopy()
    {
        throw new NotImplementedException();
        return (IGeoElement)(new GELine());
    }

    public void GetMaxMin(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin)
    {
        throw new NotImplementedException();
    }

    public int GetTanDir(EN_CLSS_POINT nUsePoint, out double dX, out double dY, out double dZ)
    {
        throw new NotImplementedException();
    }

    public EN_CLSS_RETURN_CODE GetNv(EN_CLSS_POINT nWhich, out double pdXNv, out double pdYNv, out double pdZNv)
    {
       throw new NotImplementedException();
       return EN_CLSS_RETURN_CODE.CCE_NOT_OK; 
    }

    public void ProjectToXYPlane()
    {
        throw new NotImplementedException();
    }

    public void Rotate3D(double dOrigX, double dOrigY, double dOrigZ, double dAxisX, double dAxisY, double dAxisZ, double dRotAngle, EN_CLSS_ON_OFF nRotNv)
    {
        throw new NotImplementedException();
    }
    
    public void Trace()
    {
        throw new NotImplementedException();
    }

    public void CopyGeoElementDataTo(IGeoElement pISrc)
    {
        throw new NotImplementedException();
    }

    public EN_CLSS_RETURN_CODE SetNv(EN_CLSS_POINT nWhich, double dXNv, double dYNv, double dZNv)
    {
        throw new NotImplementedException();
        return EN_CLSS_RETURN_CODE.CCE_NOT_OK; 
    }

    public void SwapXY()
    {
       throw new NotImplementedException();
    }

     public void GetRelativeReferenceFrame(EN_CLSS_POINT nWhich, out double dXx, out double dYx, out double dZx, out double dXy, out double dYy, out double dZy, out double dXz, out double dYz, out double dZz)
    {
        throw new NotImplementedException();
    }

    public EN_CLSS_ON_OFF IsLayer(EN_CLSS_GEO_LAYER nLayer)
    {
        if (Layer == nLayer)
        {
            return EN_CLSS_ON_OFF.CCL_ON;
        }
        return EN_CLSS_ON_OFF.CCL_OFF;
    }
    
    public void AddLayer(EN_CLSS_GEO_LAYER nLayer)
    {
        throw new NotImplementedException();
    }

    public void RemoveLayer(EN_CLSS_GEO_LAYER nLayer)
    {
        throw new NotImplementedException();
    }

    public int GetSharpCorners(double dDeltaIn, double dDeltaOut, int nCorner, out Geometries pGeometries)
    {
        throw new NotImplementedException();
        return -1;
    }

    public int AddLinearInOutOnSharpCorners(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning, EN_CLSS_ON_OFF nAlsoOnExtremes, int nCorner, out Geometry pGeometry)
    {
        throw new NotImplementedException();
        return -1;
    }

    public int ComparedTo(IGeoElement pSecondElement, double vTangentPrecision)
    {
        throw new NotImplementedException();
        return -1;
    }

    public int SmoothConnectionWith(IGeoElement pSecondElement, double dRadius, out IGeoElement pSmoothLink)
	{
        throw new NotImplementedException();
        return -1;
    }

	public int GetTangentFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ)
	{
        throw new NotImplementedException();
        return -1;
    }

    	public void ExplodeGeometry(out Geometry pGeometry, EN_CLSS_ON_OFF nAddPoint, int nCorner)
    {
        throw new NotImplementedException();
    }

	public int GetDistanceFromPoint(EN_CLSS_POINT nRefPoint, double dX, double dY, double dZ, out double dDistance)
	{
        throw new NotImplementedException();
        return -1;
    }

    public void GetStartEndPoints(out double dXS, out double dYS, out double dZS, out double dXE, out double dYE, out double dZE)
    {
        throw new NotImplementedException();
    }

	public void GetGeoEntity(out string pData, out int pSize)
    {
        throw new NotImplementedException();
    }
	
	public void SetGeoEntity(string pData)
    {
        throw new NotImplementedException();
    }

  }
}