using BsEnums;

namespace CommClss
{
    public interface IBaseWorkData
{
	
	EN_CLSS_WORK_TYPE Type
	{
		get;
	}

	
	int ID
	{
		get;
	
		set;
	}

	int Side
	{
		get;
	
    	set;
	}

	
	string SidesToClone
	{
		get;
	
		set;
	}

	
	string Corners
	{
		get;
	
		set;
	}
}

}