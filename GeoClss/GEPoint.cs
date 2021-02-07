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

	public void ChangeDir([In] EN_CLSS_ON_OFF nSwapTachData)
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
  } 
}