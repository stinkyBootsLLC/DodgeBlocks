//using UnityEngine;
//using System.Collections;
//using UnityEngine.Advertisements;// unity ads
//
//
//
//public class UnityAdManger : MonoBehaviour {
//
//	[SerializeField] string GameID = "1119211";  // unity ads Android Game id
//
//	private static UnityAdManger instance = null;
//
//	// Use this for initialization
//
//	void Awake ()
//	{
//		Advertisement.Initialize (GameID,false);  // unity initialize the advert // set to false = NO TEST ADS
//
//		if(UnityAdManger.instance != null)
//		{
//			Destroy(gameObject);	//just allow one adscontroller on scene over gameplay, even when you restart this level
//		}
//	}
//
//
//	void Start () 
//	{
//		if(Advertisement.IsReady())  // Unity ads
//			{
//				Advertisement.Show();
//				Debug.Log("UnityAD is Showing");
//
//			}
//	}
//
//}
