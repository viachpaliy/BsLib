using System;
using System.Collections;
using BsEnums;

namespace  GeoClss
{
public interface IGeoElement
{
	EN_CLSS_GEOELE_TYPE GeoType
	{
		get;
	}

	EN_CLSS_GEO_LAYER Layer
	{
		get;

		set;
	}

	EN_CLSS_ON_OFF PassThrough
	{
		get;

		set;
	}

	EN_CLSS_ON_OFF First
	{
		get;

		set;
	}

	GETechData TechData
	{
		get;

		set;
	}

	int Color
	{
		get;

		set;
	}

	int ID
	{
		get;

		set;
	}

	string DxfLayer
	{
		get;

		set;
	}

	int PLineID
	{
		get;

		set;
	}

	IGeoElement CreateCopy();

	void Traslate2D(double dX, double dY);
	
	void Traslate3D(double dX, double dY, double dZ);

	EN_CLSS_RETURN_CODE GetPoint(EN_CLSS_POINT nWhich, out double pdX, out double pdY, out double pdZ);
	
	void GetMaxMin(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin);
	
	void MirrorX(double dAxis, EN_CLSS_ON_OFF nMirrorNv);
	
	void MirrorY(double dAxis, EN_CLSS_ON_OFF nMirrorNv);
	
	double GetLength(out int nError);
	
	int GetTanDir(EN_CLSS_POINT nUsePoint, out double dX, out double dY, out double dZ);
	
	void Break2Elements(double dDistance, EN_CLSS_POINT nUsePoint, out IGeoElement pGeoEle);
	
	EN_CLSS_RETURN_CODE GetNv(EN_CLSS_POINT nWhich, out double pdXNv, out double pdYNv, out double pdZNv);
	
	void ChangeDir(EN_CLSS_ON_OFF nSwapTachData);
	
	void ProjectToXYPlane();

	void Rotate3D(double dOrigX, double dOrigY, double dOrigZ, double dAxisX, double dAxisY, double dAxisZ, double dRotAngle, EN_CLSS_ON_OFF nRotNv);
	
	void Trace();

	void CopyGeoElementDataTo(IGeoElement pISrc);
	
	EN_CLSS_RETURN_CODE IsValid();

	EN_CLSS_RETURN_CODE SetNv(EN_CLSS_POINT nWhich, double dXNv, double dYNv, double dZNv);
	
	void SwapXY();

	int ErrorCode();

	string GetErrorMessage(int nECode);

	void GetRelativeReferenceFrame(EN_CLSS_POINT nWhich, out double dXx, out double dYx, out double dZx, out double dXy, out double dYy, out double dZy, out double dXz, out double dYz, out double dZz);
	
	void Scale(double dScaleFactor);

	void InitCommonParameters(int nID, EN_CLSS_GEOELE_TYPE nGeoType, EN_CLSS_GEO_LAYER nLayer, EN_CLSS_ON_OFF nPassThrough, EN_CLSS_ON_OFF nFirst, int nColor, GETechData pTechData, string sDxfLayer);
	
	void GetCommonParameters(out int nID, out EN_CLSS_GEOELE_TYPE nGeoType, out EN_CLSS_GEO_LAYER nLayer, out EN_CLSS_ON_OFF nPassThrough, out EN_CLSS_ON_OFF nFirst, out int nColor, out GETechData pTechData, out string pDxfLayer);
	
	EN_CLSS_ON_OFF IsLayer(EN_CLSS_GEO_LAYER nLayer);
	
	void AddLayer(EN_CLSS_GEO_LAYER nLayer);
	
	void RemoveLayer(EN_CLSS_GEO_LAYER nLayer);
	
	int GetSharpCorners(double dDeltaIn, double dDeltaOut, int nCorner, out Geometries pGeometries);
	
	int AddLinearInOutOnSharpCorners(double dParallelLeaningIn, double dParallelLeaningOut, double dPerpendicularLeaning, double dHoriCopyingDistance, double dExtraDepthFromPanel, double dVertCopyingDistance, EN_CLSS_GEO_LAYER nHCopyingLayer, EN_CLSS_GEO_LAYER nVCopyingLayer, EN_CLSS_ON_OFF nRightPerpLeaning, EN_CLSS_ON_OFF nAlsoOnExtremes, int nCorner, out Geometry pGeometry);
	
	int ComparedTo(IGeoElement pSecondElement, double vTangentPrecision);
	
	int SmoothConnectionWith(IGeoElement pSecondElement, double dRadius, out IGeoElement pSmoothLink);
	
	int GetPointFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ);
	
	int GetTangentFromDistance(double dDistance, EN_CLSS_POINT nPoint, out double dX, out double dY, out double dZ);
	
	int Intersect(IGeoElement pGeoElement, EN_CLSS_ON_OFF nExtend1, EN_CLSS_ON_OFF nExtend2, out Geometry pSolutions);

	void ExplodeGeometry(out Geometry pGeometry, EN_CLSS_ON_OFF nAddPoint, int nCorner);

	int GetDistanceFromPoint(EN_CLSS_POINT nRefPoint, double dX, double dY, double dZ, out double dDistance);
	
	double Distance(IGeoElement pGeoElement);
	
	void GetStartEndPoints(out double dXS, out double dYS, out double dZS, out double dXE, out double dYE, out double dZE);

	void GetGeoEntity(out string pData, out int pSize);
	
	void SetGeoEntity(string pData);
  }

}