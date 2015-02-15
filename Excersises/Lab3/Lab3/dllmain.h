// dllmain.h : Declaration of module class.

class CLab3Module : public ATL::CAtlDllModuleT< CLab3Module >
{
public :
	DECLARE_LIBID(LIBID_Lab3Lib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_LAB3, "{2275844A-1E72-49EA-B8D9-3BC83569C1C9}")
};

extern class CLab3Module _AtlModule;
