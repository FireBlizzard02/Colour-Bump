using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    private InterstitialAd interstitial;

    void Start()
    {
        // Initialize the Google Mobile Ads SDK
        MobileAds.Initialize(initStatus => { });

        // Load an interstitial ad
        LoadInterstitialAd();
    }

    private async void LoadInterstitialAd()
    {
        // Replace with your own ad unit ID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712"; // Test ad unit ID

        // Create a new instance of the InterstitialAd class
        interstitial = new InterstitialAd(adUnitId);

        // Load the interstitial ad asynchronously
        try
        {
            // Requesting an interstitial ad
            AdRequest request = new AdRequest.Builder().Build();
            await interstitial.LoadAdAsync(request);
        }
        catch (Exception e)
        {
            Debug.LogError("Interstitial ad failed to load: " + e.Message);
        }
    }

    // Method to show the interstitial ad
    public void ShowInterstitial()
    {
        if (interstitial != null && interstitial.CanShowAd())
        {
            interstitial.Show();
        }
        else
        {
            Debug.Log("Interstitial ad is not ready yet.");
        }
    }
}
