using System;
using BsEnums;
using GeoClss;

namespace CommClss
{
public interface IBoring
  {

	int ID
	{
		get;

		set;
	}

	string Name
	{
		get;

		set;
	}

	EN_CLSS_ON_OFF Optimizable
	{
		get;

		set;
	}


	string TdCodeName
	{
		get;

		set;
	}


	string IsoCode
	{
		get;

		set;
	}


	int Side
	{
		get;

		set;
	}


	string Corners
	{
		get;

		set;
	}


	double X
	{
		get;

		set;
	}


	double Y
	{
		get;

		set;
	}


	double PocketDepth
	{
		get;

		set;
	}


	double Diameter
	{
		get;

		set;
	}


	double Depth
	{
		get;

		set;
	}


	EN_CLSS_ON_OFF PassThrough
	{
		get;

		set;
	}


	EN_CLSS_ANG_TYPE ChkAngZ
	{
		get;

		set;
	}


	EN_CLSS_RADIAL_TYPE ChkRadial
	{
		get;

		set;
	}


	double AngZ
	{
		get;

		set;
	}

	double AngR
	{
		get;

		set;
	}


	EN_CLSS_LEN_TYPE ChkAngularData
	{
		get;

		set;
	}


	Repetitions Repetitions
	{
		get;

		set;
	}


	EN_CLSS_DXF_BORING_TYPE DxfType
	{
		get;

		set;
	}


	Geometry DxfCustomGeometry
	{
		get;

		set;
	}


	string GeometryName
	{
		get;

		set;
	}


	EN_CLSS_ON_OFF LpzMiddle
	{
		get;

		set;
	}


	int Color
	{
		get;

		set;
	}


	string DxfLayer
	{
		get;
	
		set;
	}

	
	EN_CLSS_ON_OFF ByGeometry
	{
		get;
	
		set;
	}

	
	EN_CLSS_ON_OFF CreateOppositeWork
	{
		get;
	
		set;
	}

	
	object GeoSubIDs
	{
		get;
	
		set;
	}

	
	double AngAggr21
	{
		get;

		set;
	}


	EN_CLSS_ON_OFF SecurityPocketDeep
	{
		get;

		set;
	}


	//TdCodeStep VertStep
	//{
	//	get;
    //
	//	set;
	//}


	int SideAggr21
	{
		get;

		set;
	}

	void InitWorkElementParameters(int nID, string sName, EN_CLSS_ON_OFF nOptimizable, string sTdCodeName, string sIsoCode, int nColor, string sDxfLayer);
	
	void GetWorkElementParameters(out int nID, out string sName, out EN_CLSS_WORK_TYPE nType, out EN_CLSS_ON_OFF nOptimizable, out string sTdCodeName, out string sIsoCode, out int nColor, out string sDxfLayer);
	
	//void SetBoringParameters(int nSide, string sCorners, double dX, double dY, double dPocketDepth, double dDiameter, double dDepth, EN_CLSS_ON_OFF nPassThrough, EN_CLSS_ON_OFF nLpzMiddle, EN_CLSS_ANG_TYPE nChkAngZ, double dAngZ, double dAngR, EN_CLSS_RADIAL_TYPE nChkRadial, EN_CLSS_LEN_TYPE nChkAngularData, EN_CLSS_DXF_BORING_TYPE nDxfType, Geometry pDxfCustomGeometry, string sGeometryName, EN_CLSS_ON_OFF nByGeometry);
	
	//void GetBoringParameters(out int nSide, [MarshalAs(UnmanagedType.BStr)] out string sCorners, out double dX, out double dY, out double dPocketDepth, out double dDiameter, out double dDepth, out EN_CLSS_ON_OFF nPassThrough, out EN_CLSS_ON_OFF nLpzMiddle, out EN_CLSS_ANG_TYPE nChkAngZ, out double dAngZ, out double dAngR, out EN_CLSS_RADIAL_TYPE nChkRadial, out EN_CLSS_LEN_TYPE nChkAngularData, out EN_CLSS_DXF_BORING_TYPE nDxfType, [MarshalAs(UnmanagedType.Interface)] out Geometry pDxfCustomGeometry, out string sGeometryName, out EN_CLSS_ON_OFF nByGeometry);

	//IWorkElement CreateCopy();
  }
}