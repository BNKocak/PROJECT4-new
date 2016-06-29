package md5a95236d96ab66b60d1cd57ed5eada663;


public class EventListActivity_ViewBinder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.SimpleCursorAdapter.ViewBinder
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setViewValue:(Landroid/view/View;Landroid/database/Cursor;I)Z:GetSetViewValue_Landroid_view_View_Landroid_database_Cursor_IHandler:Android.Widget.SimpleCursorAdapter/IViewBinderInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("sBike.EventListActivity+ViewBinder, sBike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EventListActivity_ViewBinder.class, __md_methods);
	}


	public EventListActivity_ViewBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EventListActivity_ViewBinder.class)
			mono.android.TypeManager.Activate ("sBike.EventListActivity+ViewBinder, sBike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean setViewValue (android.view.View p0, android.database.Cursor p1, int p2)
	{
		return n_setViewValue (p0, p1, p2);
	}

	private native boolean n_setViewValue (android.view.View p0, android.database.Cursor p1, int p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
