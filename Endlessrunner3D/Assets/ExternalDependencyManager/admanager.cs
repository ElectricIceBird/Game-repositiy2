using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class admanager : MonoBehaviour
{
    private BannerView ad;
    private InterstitialAd insterstitial;

    public static admanager instance;
    // Start is called before the first frame update
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
   public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        
        }else{Destroy(gameObject);
        } 
           }
    void Start()
    {
     MobileAds.Initialize(InitializationStatus => { });
        this.requestAd();
    }
    private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder().Build();
    }
    private void requestAd()
    {
        string adUnitId = "	ca-app-pub-3940256099942544/6300978111";
        this.ad = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest re = new AdRequest.Builder().Build();
        this.ad.LoadAd(re);
        this.ad.LoadAd(this.CreateAdRequest());

    }
    public void RequestAdinter()
    {
           string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        if(this.insterstitial !=null )
        {
            this.insterstitial.Destroy();
        }
        this.insterstitial = new InterstitialAd(adUnitId);
        this.insterstitial.LoadAd(this.CreateAdRequest());

       }
       public void showInter()
       {
           if(this.insterstitial.IsLoaded())
           {
               insterstitial.Show();
           }else
           {
               return;
           }
       }
    // Update is called once per frame
    void Update()
    {
        
    }
}
