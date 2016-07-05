package md5a95236d96ab66b60d1cd57ed5eada663;


public class Activity4_2
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("sBike.Activity4_2, sBike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Activity4_2.class, __md_methods);
	}


	public Activity4_2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Activity4_2.class)
			mono.android.TypeManager.Activate ("sBike.Activity4_2, sBike, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
