using System;
using BsEnums;

namespace  GeoClss
{

  public interface IGETechData
  {

	EN_CLSS_SHARPCORNER SharpCorner
	{
		get;

		set;
	}


	double WorkSpeed
	{
		get;

		set;
	}

	double RotSpeed
	{
		get;

		set;
	}

	double Zi
	{
		get;

		set;
	}

	double Zf
	{
		get;

		set;
	}

	double AngleCT
	{
		get;

		set;
	}


//	Intervents StartIntervColl
//	{
//		get;
//
//		set;
//	}


//	Intervents EndIntervColl
//	{
//		get;
//
//		set;
//	}

	GETechData CreateCopy();

	void CopyTo(out GETechData pICopy);
	
	void CopyFrom(GETechData pISrc);
	
	void Init(EN_CLSS_SHARPCORNER nSharpCorner, double dZi, double dZf, double dWorkSpeed, double dRotSpeed, double dCbAxis, double dRcAxis, double dMeccCorrCb, double dGeomCorrCb, double dAb, double dAm, int nCoeffRcI, int nNotUsed2, double dX1, double dY1, double dZ1, double dX2, double dY2, double dZ2);

	void GetParameters(out EN_CLSS_SHARPCORNER nSharpCorner, out double dZi, out double dZf, out double dWorkSpeed, out double dRotSpeed, out double dCbAxis, out double dRcAxis, out double dMeccCorrCb, out double dGeomCorrCb, out double dAb, out double dAm, out int nCoeffRcI, out int nNotUsed2, out double dX1, out double dY1, out double dZ1, out double dX2, out double dY2, out double dZ2);

	int GetEdgingData(out double dCbAxis, out double dRcAxis, out double dMeccCorrCb, out double dGeomCorrCb, out double dAb, out double dAm, out int nCoeffRcI, out int nNotUsed2);

	void SetEdgingData(double dCbAxis, double dRcAxis, double dMeccCorrCb, double dGeomCorrCb, double dAb, double dAm, int nCoeffRcI, int nNotUsed2);


  }

}