package md5a00a0107bc40deec6c7fd674001bbd10;


public class AboutPage
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Frets.AboutPage, Frets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AboutPage.class, __md_methods);
	}


	public AboutPage () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AboutPage.class)
			mono.android.TypeManager.Activate ("Frets.AboutPage, Frets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
