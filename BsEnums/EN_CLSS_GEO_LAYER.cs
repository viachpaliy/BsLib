using System;

namespace BsEnums
{

  public enum EN_CLSS_GEO_LAYER
  {
	CGEL_LAYER_BASE = 1,
	CGEL_LAYER_IN = 2,
	CGEL_LAYER_OUT = 4,
	CGEL_LAYER_SIC = 8,
	CGEL_LAYER_RISALITA = 0x10,
	CGEL_LAYER_ATTACCO = 0x20,
	CGEL_LAYER_RIPOSIZ = 0x40,
	CGEL_LAYER_SHARP_CNRS = 0x80,
	CGEL_LAYER_COMPENS = 0x100,
	CGEL_LAYER_RACC_VERT = 0x200,
	CGEL_LAYER_DECELERATION = 0x400,
	CGEL_LAYER_ACCELERATION = 0x800,
	CGEL_LAYER_HORY_COPYING = 0x1000,
	CGEL_LAYER_VERT_COPYING = 0x2000,
	CGEL_LAYER_CT_ROTATION = 0x4000,
	CGEL_LAYER_GRAPHIC = 0x8000,
	CGEL_LAYER_RETRO = 0x10000,
	CGEL_LAYER_ECS_PDIN = 0x20000,
	CGEL_LAYER_ECS_PDU = 0x40000,
	CGEL_ALL = 0x7FFFF
  }

}