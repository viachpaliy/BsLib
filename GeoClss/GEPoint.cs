using System;
using System.Collections;
using BsEnums;

namespace  GeoClss
{
public class GEPoint : IGeoElement
{
    public EN_CLSS_GEOELE_TYPE GeoType
	{
		get
        {return EN_CLSS_GEOELE_TYPE.CGT_POINT ;}
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

	public double X
	{
		get;
		
		set;
	}

	public double Y
	{
		get;
		
		set;
	}

	public double Z
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

	public double XNv
	{		
		get;
	
		set;
	}

	
	public double YNv
	{
		get;
		
		set;
	}

	public double ZNv
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

    public int PLineID
	{
		get;

		set;
	}

	public EN_CLSS_RETURN_CODE GetPoint(EN_CLSS_POINT nWhich, out double pdX, out double pdY, out double pdZ)
    {
        pdX = X;
        pdY = Y;
        pdZ = Z;
        return EN_CLSS_RETURN_CODE.CCE_OK;        
    }

	public void GetPointPos(out double pdX, out double pdY, out double pdZ)
    {
        pdX = X;
        pdY = Y;
        pdZ = Z;
    }

	public void SetPointPos(double dX, double dY, double dZ)
    {
        X = dX;
        Y = dY;
        Z = dZ;
    }

	public void GetPointNv(out double pdX, out double pdY, out double pdZ)
    {
        pdX = XNv;
        pdY = YNv;
        pdZ = ZNv;
    }

	public void SetPointNv(double dX, double dY, double dZ)
    {
        XNv = dX;
        YNv = dY;
        ZNv = dZ;
    }

	public void MirrorX(double dAxis, EN_CLSS_ON_OFF nMirrorNv)
    {
        X = dAxis - (X - dAxis);
        if (nMirrorNv == EN_CLSS_ON_OFF.CCL_ON)
        {
            XNv *= -1;
        }
    }

	public void MirrorY(double dAxis, EN_CLSS_ON_OFF nMirrorNv)
    {
        Y = dAxis - (Y - dAxis);
        if (nMirrorNv == EN_CLSS_ON_OFF.CCL_ON)
        {
            YNv *= -1;
        }
    }

	public void Traslate2D(double dX, double dY)
    {
        X += dX;
        Y += dY;
    }

	public void Traslate3D(double dX, double dY, double dZ)
    {
        X += dX;
        Y += dY;
        Z += dZ;
    }

	public void ReferTo(int nOldCorner, int nNewCorner, double dWidth, double dHeight)
    {
         throw new NotImplementedException();
    }

	public void ChangeDir(EN_CLSS_ON_OFF nSwapTachData)
    {
         throw new NotImplementedException();
    }
	
	public EN_CLSS_RETURN_CODE IsValid()
    {
        return EN_CLSS_RETURN_CODE.CCE_OK; 
    }
	
	public int ErrorCode()
    {
        return (int)IsValid(); 
    }

	public string GetErrorMessage(int nECode)
    {
        return "NotImplemented";
    }

	public void Scale(double dScaleFactor)
    {
        X *= dScaleFactor;
        Y *= dScaleFactor;
    }
	
	public void InitCommonParameters(int nID, EN_CLSS_GEOELE_TYPE nGeoType, EN_CLSS_GEO_LAYER nLayer, EN_CLSS_ON_OFF nPassThrough, EN_CLSS_ON_OFF nFirst, int nColor, GETechData pTechData, string sDxfLayer)
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
        nID = ID;
        nLayer = Layer;
        nPassThrough = PassThrough;
        nFirst = First;
        nColor = Color;
        pTechData = TechData;
        sDxfLayer = DxfLayer;
    }

	public void GetPointPosAndNv(out double dX, out double dY, out double dZ, out double dXNv, out double dYNv, out double dZNv)
    {
        dX = X;
        dY = Y;
        dZ = Z;
        dXNv = XNv;
        dYNv = YNv;
        dZNv = ZNv;
    }

	void SetPointPosAndNv(double dX, double dY, double dZ, double dXNv, double dYNv, double dZNv)
    {
        X = dX;
        Y = dY;
        Z = dZ;
        XNv = dXNv;
        YNv = dYNv;
        ZNv = dZNv;
    }

    public GEPoint(GEPoint other)
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
        XNv = other.XNv;
        YNv = other.YNv;
        ZNv = other.ZNv;
        ID = other.ID;
        Layer = other.Layer;
        PassThrough = other.PassThrough;
        First = other.First;
        Color = other.Color;
        TechData = other.TechData;
        DxfLayer = other.DxfLayer;
    }

    public IGeoElement CreateCopy()
    {
        return (IGeoElement)(new GEPoint(this));
    }

    public void GetMaxMin(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin)
    {
        dXMax = X;
        dYMax = Y;
        dZMax = Z;
        dXMin = X;
        dYMin = Y;
        dZMin = Z;
    }

    public double GetLength(out int nError)
    {
        nError = (int)EN_CLSS_RETURN_CODE.CCE_POINT_OUT_LINE;
        return 0;
    }

    public int GetTanDir(EN_CLSS_POINT nUsePoint, out double dX, out double dY, out double dZ)
    {
        dX = YNv;
        dY = XNv;
        return (int)EN_CLSS_RETURN_CODE.CCE_POINT_OUT_LINE;
    }

    public void Break2Elements(double dDistance, EN_CLSS_POINT nUsePoint, out IGeoElement pGeoEle)
    {
        throw new NotImplementedException();
    }

    public EN_CLSS_RETURN_CODE GetNv(EN_CLSS_POINT nWhich, out double pdXNv, out double pdYNv, out double pdZNv)
    {
       pdXNv = XNv;
       pdYNv = YNv;
       pdZNv = ZNv;
       return (int)EN_CLSS_RETURN_CODE.CCE_POINT_OUT_LINE; 
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
        XNv = dXNv;
        YNv = dYNv;
        ZNv = dZNv;
        return EN_CLSS_RETURN_CODE.CCE_OK; 
    }

    public void SwapXY()
    {
        double temp = X;
        X = Y;
        Y = temp;
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

	public int GetPointFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ)
	{
        throw new NotImplementedException();
        return -1;
    }

	public int GetTangentFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ)
	{
        throw new NotImplementedException();
        return -1;
    }

	public int Intersect(IGeoElement pGeoElement, EN_CLSS_ON_OFF nExtend1, EN_CLSS_ON_OFF nExtend2, out Geometry pSolutions)
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

	public double Distance(IGeoElement pGeoElement)
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