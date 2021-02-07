using System;
using System.Collections;
using BsEnums;

namespace  GeoClss
{
  public interface IGeometries : IEnumerable
  {

	int Count
	{
		get;
	}

	IEnumerator GetEnumerator();

	Geometry Item(int Index);
	
	void Add(Geometry pObject, string Key = "");

	void Remove(int Index);

	void RemoveAll();

	void CollectAllInOne(out Geometry pResultGeometry);

	void SeparateConnectedGeometries(out Geometry pGeometry, out GEPoint pPoint, EN_CLSS_ON_OFF nAddStartPoint, int nColor, string sDxfLayer, int nFirstCorner, double dWidth, double dHeight);
	
	void GetBoundCoordinates(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin);
  }
}