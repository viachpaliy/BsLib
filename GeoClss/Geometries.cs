using System;
using System.Collections;
using System.Collections.Generic;
using BsEnums;

namespace  GeoClss
{
  public class Geometries : IGeometries
  {
    List<Geometry> items = new List<Geometry>();
    List<string> keys = new List<string>();

	public int Count
	{
		get
        {
          return items.Count;
        }
	}

    public Geometries(){}

	public IEnumerator GetEnumerator()
    {
        return items.GetEnumerator();
    }

	public Geometry Item(int Index)
    {
        return items[Index];
    }
	
	public void Add(Geometry pObject, string Key = "")
    {
        items.Add(pObject);
        keys.Add(Key);
    }

	public void Remove(int nIndex)
    {
        items.RemoveAt(nIndex);
        keys.RemoveAt(nIndex);
    }

	public void RemoveAll()
    {
        items.Clear();
        keys.Clear();
    }

	public void CollectAllInOne(out Geometry pResultGeometry)
    {
        throw new NotImplementedException();
    }

	public void SeparateConnectedGeometries(out Geometry pGeometry, out GEPoint pPoint, EN_CLSS_ON_OFF nAddStartPoint, int nColor, string sDxfLayer, int nFirstCorner, double dWidth, double dHeight)
    {
        throw new NotImplementedException();
    }
	
	public void GetBoundCoordinates(out double dXMax, out double dYMax, out double dZMax, out double dXMin, out double dYMin, out double dZMin)
    {
        throw new NotImplementedException();
    }

  }

}