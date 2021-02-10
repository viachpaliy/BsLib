using BsEnums;

namespace CommClss
{
public class Repetitions : IRepetitions
{

	public EN_CLSS_REP_TYPE Type
	{
		get;
	
		set;
	}

	
	public int Count
	{
		get;
	
    	set;
	}

	
	public double StepX
	{
		get;
	
		set;
	}

	
	public double StepY
	{
		get;
	
		set;
	}

	
	public double StepZ
	{
		get;
	
		set;
	}

	
	public double StepRadius
	{
		get;
	
		set;
	}

	
	public double StepInitAng
	{
		get;
	
		set;
	}

	
	public double StepAng
	{
		get;
	
		set;
	}

	
	public double XCenter
	{
		get;
	
		set;
	}

	
	public double YCenter
	{
		get;
	
		set;
	}

	
	public double Distance
	{
		get;
	
		set;
	}

	
	public double Angle
	{
		get;
	
		set;
	}

	
	public EN_CLSS_ON_OFF LockFirstWork
	{
		get;
	
		set;
	}

	public Repetitions(Repetitions other){
        Type = other.Type;
        Count = other.Count;
        StepX = other.StepX;
        StepY = other.StepY;
        StepZ = other.StepZ;
        StepRadius = other.StepRadius;
        StepInitAng = other.StepInitAng;
        StepAng = other.StepAng;
        XCenter = other.XCenter;
        YCenter = other.YCenter;
        Distance = other.Distance;
        Angle = other.Angle;
        LockFirstWork = other.LockFirstWork;
    }

	public void Init(EN_CLSS_REP_TYPE nType, int nCount, double dStepX, double dStepY, double dStepRadius, double dStepInitAng, double dStepAng, double dXc, double dYc, EN_CLSS_ON_OFF nLockFirstWork)
      {
        Type = nType;
        Count = nCount;
        StepX = dStepX;
        StepY = dStepY;
        StepRadius = dStepRadius;
        StepInitAng = dStepInitAng;
        StepAng = dStepAng;
        XCenter = dXc;
        YCenter = dYc;
        LockFirstWork = nLockFirstWork;
      }
	
	public void SetRepetitionParameters(EN_CLSS_REP_TYPE nType, int nCount, double dStepX, double dStepY, double dDistance, double dAngle, double dStepRadius, double dStepInitAng, double dStepAng, double dXc, double dYc, EN_CLSS_ON_OFF nLockFirstWork)
      {
        Type = nType;
        Count = nCount;
        StepX = dStepX;
        StepY = dStepY;
		Distance = dDistance;
		Angle = dAngle;
        StepRadius = dStepRadius;
        StepInitAng = dStepInitAng;
        StepAng = dStepAng;
        XCenter = dXc;
        YCenter = dYc;
        LockFirstWork = nLockFirstWork;
      }

	public void GetRepetitionParameters(out EN_CLSS_REP_TYPE nType, out int nCount, out double dStepX, out double dStepY, out double dDistance, out double dAngle, out double dStepRadius, out double dStepInitAng, out double dStepAng, out double dXc, out double dYc, out EN_CLSS_ON_OFF nLockFirstWork)
     {
        nType = Type;
        nCount = Count;
        dStepX = StepX;
        dStepY = StepY;
		dDistance = Distance;
		dAngle = Angle;
        dStepRadius = StepRadius;
        dStepInitAng = StepInitAng;
        dStepAng = StepAng;
        dXc = XCenter ;
        dYc = YCenter ;
        nLockFirstWork = LockFirstWork;
      }

	public Repetitions CreateCopy()
    {
        return new Repetitions(this);
    }
    
  }
}