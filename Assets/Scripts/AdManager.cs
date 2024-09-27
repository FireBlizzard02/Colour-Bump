using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
//     private InterstitialAd interstitial;

//     void Start()
//     {
//         MobileAds.Initialize(initStatus => { });

//         RequestInterstitial();
//     }

//     private void RequestInterstitial()
//     {

//         string adUnitId = "ca-app-pub-3940256099942544/1033173712"; // dummy id

//         interstitial = new InterstitialAd(adUnitId);

//         interstitial.OnAdClosed += HandleOnAdClosed;


//         AdRequest request = new AdRequest.Builder().Build();
//         interstitial.LoadAd(request);
//     }

//     public void ShowInterstitial()
//     {
//         if (interstitial.IsLoaded())
//         {
//             interstitial.Show();
//         }
//         else
//         {
//             Debug.Log("Interstitial ad is not ready yet.");
//         }
//     }

//     private void HandleOnAdClosed(object sender, System.EventArgs args)
//     {
//         Debug.Log("Interstitial ad closed");

//         interstitial.Destroy();
//         RequestInterstitial();

//     }

//     private void OnDestroy()
//     {
//         if (interstitial != null)
//         {
//             interstitial.OnAdClosed -= HandleOnAdClosed;
//             interstitial.Destroy();
//         }
//     }
}
