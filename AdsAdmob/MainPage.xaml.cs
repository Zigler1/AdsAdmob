using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MarcTron.Plugin;

namespace AdsAdmob
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CrossMTAdmob.Current.OnInterstitialLoaded += (sender, e) => { CrossMTAdmob.Current.ShowInterstitial(); };
            CrossMTAdmob.Current.OnRewardedVideoAdLoaded += (sender, e) => { CrossMTAdmob.Current.ShowRewardedVideo(); };
        }

        private void interstitial_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial("Interstitial Ad Id");
            
        }

        private void reward_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo("Reward Video Ad Id");
        }
    }
}

