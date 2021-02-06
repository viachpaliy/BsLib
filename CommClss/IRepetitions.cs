using BsEnums;

namespace CommClss
{
public interface IRepetitions
{

	EN_CLSS_REP_TYPE Type
	{
		get;
	
		set;
	}

	
	int Count
	{
		get;
	
    	set;
	}

	
	double StepX
	{
		get;
	
		set;
	}

	
	double StepY
	{
		get;
	
		set;
	}

	
	double StepZ
	{
		get;
	
		set;
	}

	
	double StepRadius
	{
		get;
	
		set;
	}

	
	double StepInitAng
	{
		get;
	
		set;
	}

	
	double StepAng
	{
		get;
	
		set;
	}

	
	double XCenter
	{
		get;
	
		set;
	}

	
	double YCenter
	{
		get;
	
		set;
	}

	
	double Distance
	{
		get;
	
		set;
	}

	
	double Angle
	{
		get;
	
		set;
	}

	
	EN_CLSS_ON_OFF LockFirstWork
	{
		get;
	
		set;
	}

	
	void Init(EN_CLSS_REP_TYPE nType, int nCount, double dStepX, double dStepY, double dStepRadius, double dStepInitAng, double dStepAng, double dXc, double dYc, EN_CLSS_ON_OFF nLockFirstWork);

	
	void SetRepetitionParameters(EN_CLSS_REP_TYPE nType, int nCount, double dStepX, double dStepY, double dDistance, double dAngle, double dStepRadius, double dStepInitAng, double dStepAng, double dXc, double dYc, EN_CLSS_ON_OFF nLockFirstWork);


	void GetRepetitionParameters(out EN_CLSS_REP_TYPE nType, out int nCount, out double dStepX, out double dStepY, out double dDistance, out double dAngle, out double dStepRadius, out double dStepInitAng, out double dStepAng, out double dXc, out double dYc, out EN_CLSS_ON_OFF nLockFirstWork);

	Repetitions CreateCopy();
    
  }
}