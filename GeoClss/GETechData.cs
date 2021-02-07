using System;
using BsEnums;

namespace  GeoClss
{

  public class GETechData : IGETechData
  {

    double CbAxis = 0;
    double RcAxis =0;
    double MeccCorrCb = 0;
    double GeomCorrCb = 0;
    double Ab = 0;
    double Am = 0;
    int CoeffRcI = 0;
    int NotUsed2 = 0;

	public EN_CLSS_SHARPCORNER SharpCorner
	{
		get;

		set;
	}


	public double WorkSpeed
	{
		get;

		set;
	}

	public double RotSpeed
	{
		get;

		set;
	}

	public double Zi
	{
		get;

		set;
	}

	public double Zf
	{
		get;

		set;
	}

	public double AngleCT
	{
		get;

		set;
	}


//	public Intervents StartIntervColl
//	{
//		get;
//
//		set;
//	}


//	public Intervents EndIntervColl
//	{
//		get;
//
//		set;
//	}

    public GETechData(GETechData other)
    {
        SharpCorner = other.SharpCorner;
        WorkSpeed = other.WorkSpeed;
        RotSpeed = other.RotSpeed;
        Zi = other.Zi;
        Zf = other.Zf;
        AngleCT = other.AngleCT;
    //  StartIntervColl = other.StartIntervColl;
    //  EndIntervColl = other.EndIntervColl;
    }

	public GETechData CreateCopy()
    {
        return new GETechData(this);
    }

	public void CopyTo(out GETechData pICopy)
    {
        pICopy.SharpCorner = SharpCorner;
        pICopy.WorkSpeed = WorkSpeed;
        pICopy.RotSpeed = RotSpeed;
        pICopy.Zi = Zi;
        pICopy.Zf = Zf;
        pICopy.AngleCT = AngleCT;
    //  pICopy.StartIntervColl = StartIntervColl;
    //  pICopy.EndIntervColl = EndIntervColl; 
    }
	
	public void CopyFrom(GETechData pISrc)
    {
        SharpCorner = pISrc.SharpCorner;
        WorkSpeed = pISrc.WorkSpeed;
        RotSpeed = pISrc.RotSpeed;
        Zi = pISrc.Zi;
        Zf = pISrc.Zf;
        AngleCT = pISrc.AngleCT;
    //  StartIntervColl = pISrc.StartIntervColl;
    //  EndIntervColl = pISrc.EndIntervColl; 
    }
	
	public void Init(EN_CLSS_SHARPCORNER nSharpCorner, double dZi, double dZf, double dWorkSpeed, double dRotSpeed, double dCbAxis, double dRcAxis, double dMeccCorrCb, double dGeomCorrCb, double dAb, double dAm, int nCoeffRcI, int nNotUsed2, double dX1, double dY1, double dZ1, double dX2, double dY2, double dZ2)
    {
        SharpCorner = nSharpCorner;
        WorkSpeed = dWorkSpeed;
        RotSpeed = dRotSpeed;
        Zi = dZi;
        Zf = dZf;
   
    }

	public void GetParameters(out EN_CLSS_SHARPCORNER nSharpCorner, out double dZi, out double dZf, out double dWorkSpeed, out double dRotSpeed, out double dCbAxis, out double dRcAxis, out double dMeccCorrCb, out double dGeomCorrCb, out double dAb, out double dAm, out int nCoeffRcI, out int nNotUsed2, out double dX1, out double dY1, out double dZ1, out double dX2, out double dY2, out double dZ2)
    {
        nSharpCorner = SharpCorner;
        dWorkSpeed = WorkSpeed;
        dRotSpeed = RotSpeed;
        dZi = Zi;
        dZf = Zf;   
    }

	public int GetEdgingData(out double dCbAxis, out double dRcAxis, out double dMeccCorrCb, out double dGeomCorrCb, out double dAb, out double dAm, out int nCoeffRcI, out int nNotUsed2)
    {
        int errorCode = 0;
        dCbAxis = CbAxis;
        dRcAxis = RcAxis;
        dMeccCorrCb = MeccCorrCb;
        dGeomCorrCb = GeomCorrCb;
        dAb = Ab;
        dAm = Am;
        nCoeffRcI = CoeffRcI;
        nNotUsed2 = NotUsed2;
        return errorCode;       
    }

	public void SetEdgingData(double dCbAxis, double dRcAxis, double dMeccCorrCb, double dGeomCorrCb, double dAb, double dAm, int nCoeffRcI, int nNotUsed2)
    {
        CbAxis = dCbAxis;
        RcAxis = dRcAxis;
        MeccCorrCb = dMeccCorrCb;
        GeomCorrCb = dGeomCorrCb;
        Ab = dAb;
        Am = dAm;
        CoeffRcI = nCoeffRcI;
        NotUsed2 = nNotUsed2;
    }

  }

}