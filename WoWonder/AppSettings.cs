﻿//##############################################
//Cᴏᴘʏʀɪɢʜᴛ 2020 DᴏᴜɢʜᴏᴜᴢLɪɢʜᴛ Codecanyon Item 19703216
//Elin Doughouz >> https://www.facebook.com/Elindoughouz
//====================================================

//For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

using System.Collections.Generic;
using SocketIOClient.Transport;
using WoWonder.Helpers.Model;
using WoWonderClient;
using static WoWonder.Activities.NativePost.Extra.WRecyclerView;

namespace WoWonder
{
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">demo.wowonder.com</string>
        /// </summary>
        public static readonly string TripleDesAppServiceProvider = "1AyC1ApTze+hNZz3RU9a1qFYs6rMtXY9xky1ztO29fkId/khKlQS5MK0MjHovWDbfQEHPGioGzoryaICLicdL8r5dHe0pRlKmPrLr6LNeZRLPn11TRSozLlK/6iUd4ZkD6CgrUsiYKlOGOE7ibPHdB7i0ngdnLVrDisJEk3duXBFiwurJ7nG+UimqdYssQnrrncvkvr43myobZ/I5wxPz+2Y9ZSnf51zDe2gfYV1+yRNTz3XLnA+991vHlKXX+n8yqEl8+Z2JPTDsapOAJMERK41Yegsz0IeciubQumnqmKpZwUNWi3yEGhLfmwIuFndoEmabztQHSBV1oUgzV2aqh4PuRb6Vi0xsX485t1TcLjlJR0dZYr1FNlRLFiTfdsBT+vN6UookOdMNEMOhBmV3J7M4aFqvfOx1UJePeJTd/XFo2xKbqny8A9MXhsahvWEmmXm5lbi8xgmaLQq/trN8Kuurc4SE8+AHoBC5/fxU4tas9Zj1UZ5rZ4KjycSGMpgO1ZP67weQqtzEjiS5NEZLolxKN+KpU/zlmbXmSQvcfWDc9OeMWdfdkz4yUYjo8xD0ODLyuyoEg0iDfSD+AWNzLFVt4jv7IAItFFRSYJX6dBZ7wGd78jGSsmU/+PxtTdFmuAdNZ9t2leNdrQfzxXQL/qtwCYQo27/MCpLuuc6/BDwyMgHjZNq8LjbzO9i3XKUO6L7W++akdkrdxwic897DBOPwVYh1ur1FNk4dGiLLJlI4dkr/zhshm9YxZCHIYKi13jNR7XzNEyE9mV5MbcVxKCtw5LleR3cSpZmAPX6yR+/VMwSs2xtPI9XfX6lWZk5x2dQv1RJLOXF1D1iJ5LialHkjWVcygNbESqoda/XO98Ce0ZQYKC9PXHXkQ0MBc4ATtiPBJ0mlMPVXxYGrz0C77wK/XC1m4v1mvASRKW66VTM6BAEZHODxR/b3Si4qLD0rs01XP9EIkRyXzBKhk0oLJb6QeFktGUq83Uep7YjKAcTBWeFJRo9kz/I5O1CCbnuZVXb4bGsP5wd72abjOl0g4aWi/A3MAXgsDvA961rs258+V1W6fHHkYnSJlQkQkKfWeIWBY3Nysl0Fzum0O2ia3xiyeqM+EN8BJLsDdBXgN/uWpmzFAXeNxuJRImIdUREGFNUD+k3vQAREQv9/rZYG/xM9TXXGwhGI3QB0jttz0nuyGkBqDzDMyRLVAr9vSVTilQbk2r56Vlp/paGBjRH2T76OdLfXdJRMr4dSOXBPyt6Hs231/0rKT4Bs8xB4ibLt8ifJaNspcyJeMIEmKqMOz6/nA0jVmwnJVnhVdQ5DYV6PhJO9whUQUXqsPEsf8urxrD4Y0cCkUAbTF7kuSdO0ofep1nQ9xUJ6ZQG5nOulsZBQ9jexbBrbwHYtAWW63oJuB/FnWEgeJ9sl+w+L4pu/8rzLcFlPd9M0WWR6poniwMLdcuHyuH0EEv0Gkh+rVqXapQAjbMPB01BdrqxO1nH6d5KwGbv9CDvibOEywGjSb9H4Nfcfd0bT09yNZSMrBCJl/W1kjpG3AG6/0d6y+ey1Rn7G3G7gOD9/mkSJl9GYdcLPbC+T6NI4aYZEKDSWgjPrzVmzBfNkdz9WUcHQEn0QbVVUWMOEdocjdIedlkQJK9azsjD/qpgbUM9CHhCQvQi2hqfjZdp/WOenjVM2C9NFg==";

        //Main Settings >>>>>
        //*********************************************************
        public static string Version = "4.4";
        public static readonly string ApplicationName = "WoWonder Combined";
        public static readonly string DatabaseName = "WowonderSocial";

        // Friend system = 0 , follow system = 1
        public static readonly int ConnectivitySystem = 1;

        /// <summary>
        /// When you select the application mode type.. some settings will be changed and some features will be deactivated..
        /// ==============================================
        /// AppMode.Default : (Facebook) Mode
        /// AppMode.LinkedIn : (Jobs) Mode
        /// 
        /// AppMode.Instagram >> #Next Version 
        /// ==============================================
        /// </summary>
        public static readonly AppMode AppMode = AppMode.Default; //#New

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#A52729";

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar

        //Set Language User on site from phone 
        public static readonly bool SetLangUser = true;

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "64974c58-9993-40ed-b782-0814edc401ea";
        public static string MsgOneSignalAppId = "64974c58-9993-40ed-b782-0814edc401ea";
         
        // WalkThrough Settings >>
        //*********************************************************
        public static readonly bool ShowWalkTroutPage = true;

        //Main Messenger settings
        //*********************************************************
        public static readonly bool MessengerIntegration = true;
        public static readonly bool ShowDialogAskOpenMessenger = false;
        public static readonly string MessengerPackageName = "com.wowondermessenger.app"; //APK name on Google Play

        //AdMob >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;
     
        public static readonly bool RewardedAdvertisingSystem = true; //#New

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 5;
        public static readonly int ShowAdRewardedVideoCount = 5;
        public static readonly int ShowAdNativeCount = 40;
        public static readonly int ShowAdNativeReelsCount = 4;
        public static readonly int ShowAdAppOpenCount = 3;

        public static readonly bool ShowAdMobBanner = true;
        public static readonly bool ShowAdMobInterstitial = true;
        public static readonly bool ShowAdMobRewardVideo = true;
        public static readonly bool ShowAdMobNative = false;
        public static readonly bool ShowAdMobNativePost = false;
        public static readonly bool ShowAdMobAppOpen = true;
        public static readonly bool ShowAdMobRewardedInterstitial = true;

        public static readonly string AdInterstitialKey = "ca-app-pub-5135691635931982/3276797899";
        public static readonly string AdRewardVideoKey = "ca-app-pub-5135691635931982/8193070896";
        public static readonly string AdAdMobNativeKey = "ca-app-pub-5135691635931982/4917290429";
        public static readonly string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/3449206524";
        public static readonly string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/5364486052";

        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly bool ShowFbBannerAds = false;
        public static readonly bool ShowFbInterstitialAds = false;
        public static readonly bool ShowFbRewardVideoAds = false;
        public static readonly bool ShowFbNativeAds = false;

        //YOUR_PLACEMENT_ID
        public static readonly string AdsFbBannerKey = "822630268752414_960722928276480";
        public static readonly string AdsFbInterstitialKey = "822630268752414_960722824943157";
        public static readonly string AdsFbRewardVideoKey = "822630268752414_960723038276469";
        public static readonly string AdsFbNativeKey = "822630268752414_960723178276455";

        //Ads AppLovin >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowAppLovinBannerAds = false;
        public static readonly bool ShowAppLovinInterstitialAds = true;
        public static readonly bool ShowAppLovinRewardAds = true;

        public static readonly string AdsAppLovinBannerId = "27de87b390bb5884";
        public static readonly string AdsAppLovinInterstitialId = "7af32ee3997a12d7";
        public static readonly string AdsAppLovinRewardedId = "99d027a690382f70";
        //********************************************************* 

        public static readonly bool EnableRegisterSystem = true;

        /// <summary>
        /// true => Only over 18 years old
        /// false => all 
        /// </summary> 
        public static readonly bool ShowBirthdayInRegister = false; //#New
        public static readonly bool IsUserYearsOld = true;
        public static readonly bool AddAllInfoPorfileAfterRegister = true;

        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        //Code Time Zone (true => Get from Internet , false => Get From #CodeTimeZone )
        //*********************************************************
        public static readonly bool AutoCodeTimeZone = true;
        public static readonly string CodeTimeZone = "UTC";

        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = false;

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file 
        //Facebook >> ../values/analytic.xml .. line 10-11 
        //Google >> ../values/analytic.xml .. line 15 
        //*********************************************************
        public static readonly bool EnableSmartLockForPasswords = false;

        public static readonly bool ShowFacebookLogin = true;
        public static readonly bool ShowGoogleLogin = true;

        public static readonly string ClientId = "430795656343-679a7fus3pfr1ani0nr0gosotgcvq2s8.apps.googleusercontent.com";

        //########################### 

        //Main Slider settings
        //*********************************************************
        public static readonly PostButtonSystem PostButton = PostButtonSystem.Reaction;
        public static readonly ToastTheme ToastTheme = ToastTheme.Default;

        /// <summary>
        /// None : To disable Reels video on the app 
        /// </summary>
        public static readonly ReelsPosition ReelsPosition = ReelsPosition.Tab;
        public static readonly bool ShowYouTubeReels = false; //#New
        public static readonly bool ShowUsernameReels = false; //#New


        public static readonly bool ShowBottomAddOnTab = true;

        public static readonly long RefreshAppAPiSeconds = 30000; //#New

        public static readonly bool ShowAlbum = true;
        public static bool ShowArticles = true;
        public static bool ShowPokes = true;
        public static bool ShowCommunitiesGroups = true;
        public static bool ShowCommunitiesPages = true;
        public static bool ShowMarket = true;
        public static readonly bool ShowPopularPosts = true;
        /// <summary>
        /// if selected false will remove boost post and get list Boosted Posts
        /// </summary>
        public static readonly bool ShowBoostedPosts = true;
        public static readonly bool ShowBoostedPages = true;
        public static bool ShowMovies = true;
        public static readonly bool ShowNearBy = true;
        public static bool ShowStory = true;
        public static readonly bool ShowSavedPost = true;
        public static readonly bool ShowUserContacts = true;
        public static bool ShowJobs = true;
        public static bool ShowCommonThings = true;
        public static bool ShowFundings = true;
        public static readonly bool ShowMyPhoto = true;
        public static readonly bool ShowMyVideo = true;
        public static bool ShowGames = true;
        public static bool ShowMemories = true;
        public static readonly bool ShowOffers = true;
        public static readonly bool ShowNearbyShops = true;

        public static readonly bool ShowSuggestedPage = true;
        public static readonly bool ShowSuggestedGroup = true;
        public static readonly bool ShowSuggestedUser = true;

        public static readonly bool ShowCommentImage = true; //#New
        public static readonly bool ShowCommentRecordVoice = true; //#New

        //count times after entering the Suggestion is displayed
        public static readonly int ShowSuggestedPageCount = 90;
        public static readonly int ShowSuggestedGroupCount = 70;
        public static readonly int ShowSuggestedUserCount = 50;

        //allow download or not when share
        public static readonly bool AllowDownloadMedia = true;

        public static readonly bool ShowAdvertise = true;

        /// <summary>
        /// https://rapidapi.com/api-sports/api/covid-193
        /// you can get api key and host from here https://prnt.sc/wngxfc 
        /// </summary>
        public static readonly bool ShowInfoCoronaVirus = false;
        public static readonly string KeyCoronaVirus = "164300ef98msh0911b69bed3814bp131c76jsneaca9364e61f";
        public static readonly string HostCoronaVirus = "covid-193.p.rapidapi.com";

        public static readonly bool ShowLive = true;
        public static readonly string AppIdAgoraLive = "e0a8d952a4d54ebc8b646a66d8c0466c";

        //Events settings
        //*********************************************************  
        public static bool ShowEvents = true;
        public static readonly bool ShowEventGoing = true;
        public static readonly bool ShowEventInvited = true;
        public static readonly bool ShowEventInterested = true;
        public static readonly bool ShowEventPast = true;

        // Story >>
        //*********************************************************
        //Set a story duration >> Sec
        public static readonly long StoryImageDuration = 7;
        public static readonly long StoryVideoDuration = 30;

        /// <summary>
        /// If it is false, it will appear only for the specified time in the value of the StoryVideoDuration
        /// </summary>
        public static readonly bool ShowFullVideo = false;

        public static readonly bool EnableStorySeenList = true;
        public static readonly bool EnableReplyStory = true;

        /// <summary>
        /// https://dashboard.stipop.io/
        /// you can get api key from here https://prnt.sc/26ofmq9
        /// </summary>
        public static readonly string StickersApikey = "950a22e795ca1f047842854e3305a5df";

        //*********************************************************

        /// <summary>
        ///  Currency
        /// CurrencyStatic = true : get currency from app not api 
        /// CurrencyStatic = false : get currency from api (default)
        /// </summary>
        public static readonly bool CurrencyStatic = false;
        public static readonly string CurrencyIconStatic = "$";
        public static readonly string CurrencyCodeStatic = "USD";
        public static readonly string CurrencyFundingPriceStatic = "$";

        //Profile settings
        //*********************************************************
        public static readonly bool ShowGift = true;
        public static readonly bool ShowWallet = true;
        public static readonly bool ShowGoPro = true;
        public static readonly bool ShowAddToFamily = true;

        public static readonly bool ShowUserGroup = false;
        public static readonly bool ShowUserPage = false;
        public static readonly bool ShowUserImage = true;
        public static readonly bool ShowUserSocialLinks = false;

        public static readonly CoverImageStyle CoverImageStyle = CoverImageStyle.CenterCrop;

        /// <summary>
        /// The default value comes from the site .. in case it is not available, it is taken from these values
        /// </summary>
        public static readonly string WeeklyPrice = "3";
        public static readonly string MonthlyPrice = "8";
        public static readonly string YearlyPrice = "89";
        public static readonly string LifetimePrice = "259";

        //Native Post settings
        //********************************************************* 
        public static readonly bool ShowTextWithSpace = true;

        public static readonly bool ShowTextShareButton = false;
        public static readonly bool ShowShareButton = true;

        public static readonly int AvatarPostSize = 60;
        public static readonly int ImagePostSize = 200;
        public static readonly string PostApiLimitOnScroll = "8";

        public static readonly string PostApiLimitOnBackground = "10";

        public static readonly bool AutoPlayVideo = true;

        public static readonly bool EmbedDeepSoundPostType = true;
        public static readonly VideoPostTypeSystem EmbedFacebookVideoPostType = VideoPostTypeSystem.EmbedVideo;
        public static readonly VideoPostTypeSystem EmbedVimeoVideoPostType = VideoPostTypeSystem.EmbedVideo;
        public static readonly VideoPostTypeSystem EmbedPlayTubeVideoPostType = VideoPostTypeSystem.EmbedVideo;
        public static readonly VideoPostTypeSystem EmbedTikTokVideoPostType = VideoPostTypeSystem.Link;
        public static readonly VideoPostTypeSystem EmbedTwitterPostType = VideoPostTypeSystem.Link;
        public static readonly bool ShowSearchForPosts = true;
        public static readonly bool EmbedLivePostType = true;

        public static readonly string PlayTubeShortUrlSite = "https://ptub.app/"; //#New
         
        //new posts users have to scroll back to top
        public static readonly bool ShowNewPostOnNewsFeed = true;
        public static readonly bool ShowAddPostOnNewsFeed = false;
        public static readonly bool ShowCountSharePost = true;

        /// <summary>
        /// Post Privacy
        /// ShowPostPrivacyForAllUser = true : all posts user have icon Privacy 
        /// ShowPostPrivacyForAllUser = false : just my posts have icon Privacy (default)
        /// </summary>
        public static readonly bool ShowPostPrivacyForAllUser = false;

        public static readonly bool EnableVideoCompress = true;
        public static readonly bool EnableFitchOgLink = true;

        /// <summary>
        /// On : if the length of the text is more than 50 characters will be text is bigger
        /// Off : all text same size
        /// </summary>
        public static readonly VolumeState TextSizeDescriptionPost = VolumeState.On;//#New

        //Trending page
        //*********************************************************   
        public static readonly bool ShowTrendingPage = true;

        public static readonly bool ShowProUsersMembers = true;
        public static readonly bool ShowPromotedPages = true;
        public static readonly bool ShowTrendingHashTags = true;
        public static readonly bool ShowLastActivities = true;
        public static readonly bool ShowShortcuts = true;
        public static readonly bool ShowFriendsBirthday = true;
        public static readonly bool ShowAnnouncement = true;

        /// <summary>
        /// https://www.weatherapi.com
        /// </summary>
        public static readonly WeatherType WeatherType = WeatherType.Celsius;
        public static readonly bool ShowWeather = true;
        public static readonly string KeyWeatherApi = "a413d0bf31a44369a16140106221804";

        /// <summary>
        /// https://openexchangerates.org
        /// #Currency >> Your currency
        /// #Currencies >> you can use just 3 from those : USD,EUR,DKK,GBP,SEK,NOK,CAD,JPY,TRY,EGP,SAR,JOD,KWD,IQD,BHD,DZD,LYD,AED,QAR,LBP,OMR,AFN,ALL,ARS,AMD,AUD,BYN,BRL,BGN,CLP,CNY,MYR,MAD,ILS,TND,YER
        /// </summary>
        public static readonly bool ShowExchangeCurrency = false;
        public static readonly string KeyCurrencyApi = "644761ef2ba94ea5aa84767109d6cf7b";
        public static readonly string ExCurrency = "USD";
        public static readonly string ExCurrencies = "EUR,GBP,TRY";
        public static readonly List<string> ExCurrenciesIcons = new List<string>() { "€", "£", "₺" };

        //********************************************************* 

        /// <summary>
        /// you can edit video using FFMPEG 
        /// </summary>
        public static readonly bool EnableVideoEditor = true;


        public static readonly bool ShowUserPoint = true;

        //Add Post
        public static readonly AddPostSystem AddPostSystem = AddPostSystem.AllUsers;
        public static readonly GalleryIntentSystem GalleryIntentSystem = GalleryIntentSystem.Pix; //#New

        public static readonly bool ShowGalleryImage = true;
        public static readonly bool ShowGalleryVideo = true;
        public static readonly bool ShowMention = true;
        public static readonly bool ShowLocation = true;
        public static readonly bool ShowFeelingActivity = true;
        public static readonly bool ShowFeeling = true;
        public static readonly bool ShowListening = true;
        public static readonly bool ShowPlaying = true;
        public static readonly bool ShowWatching = true;
        public static readonly bool ShowTraveling = true;
        public static readonly bool ShowGif = true;
        public static readonly bool ShowFile = true;
        public static readonly bool ShowMusic = true;
        public static readonly bool ShowPolls = true;
        public static readonly bool ShowColor = true;
        public static readonly bool ShowVoiceRecord = true;

        public static readonly bool ShowAnonymousPrivacyPost = true;

        //Advertising 
        public static readonly bool ShowAdvertisingPost = true;

        //Settings Page >> General Account
        public static readonly bool ShowSettingsGeneralAccount = true;
        public static readonly bool ShowSettingsAccount = true;
        public static readonly bool ShowSettingsSocialLinks = true;
        public static readonly bool ShowSettingsPassword = true;
        public static readonly bool ShowSettingsBlockedUsers = true;
        public static readonly bool ShowSettingsDeleteAccount = true;
        public static readonly bool ShowSettingsTwoFactor = true;
        public static readonly bool ShowSettingsManageSessions = true;
        public static readonly bool ShowSettingsVerification = true;

        public static readonly bool ShowSettingsSocialLinksFacebook = true;
        public static readonly bool ShowSettingsSocialLinksTwitter = true;
        public static readonly bool ShowSettingsSocialLinksGoogle = true;
        public static readonly bool ShowSettingsSocialLinksVkontakte = true;
        public static readonly bool ShowSettingsSocialLinksLinkedin = true;
        public static readonly bool ShowSettingsSocialLinksInstagram = true;
        public static readonly bool ShowSettingsSocialLinksYouTube = true;

        //Settings Page >> Privacy
        public static readonly bool ShowSettingsPrivacy = true;
        public static readonly bool ShowSettingsNotification = true;

        //Settings Page >> Tell a Friends (Earnings)
        public static readonly bool ShowSettingsInviteFriends = true;

        public static readonly bool ShowSettingsShare = true;
        public static readonly bool ShowSettingsMyAffiliates = true;
        public static readonly bool ShowWithdrawals = true;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// Just replace it with this 5 lines of code
        /// <uses-permission android:name="android.permission.READ_CONTACTS" />
        /// <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" />
        /// </summary>
        public static readonly bool InvitationSystem = true;

        //Settings Page >> Help && Support
        public static readonly bool ShowSettingsHelpSupport = true;

        public static readonly bool ShowSettingsHelp = true;
        public static readonly bool ShowSettingsReportProblem = true;
        public static readonly bool ShowSettingsAbout = true;
        public static readonly bool ShowSettingsPrivacyPolicy = true;
        public static readonly bool ShowSettingsTermsOfUse = true;

        public static readonly bool ShowSettingsRateApp = true;
        public static readonly int ShowRateAppCount = 5;

        public static readonly bool ShowSettingsUpdateManagerApp = false;

        public static readonly bool ShowSettingsInvitationLinks = true;
        public static readonly bool ShowSettingsMyInformation = true;

        public static readonly bool ShowSuggestedUsersOnRegister = true;


        public static readonly bool ShowAddress = true;//#New 

        //Set Theme Tab
        //*********************************************************
        public static TabTheme SetTabDarkTheme = TabTheme.Light;
        public static readonly MoreTheme MoreTheme = MoreTheme.Grid;

        //Bypass Web Errors  
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;

        //Payment System
        //*********************************************************
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static readonly bool ShowInAppBilling = true;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc - https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = true;
        public static readonly string MerchantAccountId = "test";

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4ccmn4t7s******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******";

        public static readonly bool ShowCreditCard = true;
        public static readonly bool ShowBankTransfer = true;

        public static readonly bool ShowCashFree = true;//#New 
        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR";//#New 

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 28 
        /// </summary>
        public static readonly bool ShowRazorPay = true;//#New 
        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "INR";//#New 

        public static readonly bool ShowAuthorizeNet = true;//#New 
        public static readonly bool ShowSecurionPay = true;//#New 
        public static readonly bool ShowIyziPay = true;//#New 
        public static readonly bool ShowPayStack = true;//#New  
        public static readonly bool ShowPaySera = true;//#New 
        public static readonly bool ShowAamarPay = true;//#New 

        /// <summary>
        /// FlutterWave get Api Keys From https://app.flutterwave.com/dashboard/settings/apis/live
        /// </summary>
        public static readonly bool ShowFlutterWave = true;//#New 
        public static readonly string FlutterWaveCurrency = "NGN";//#New 
        public static readonly string FlutterWavePublicKey = "FLWPUBK_TEST-9c877b3110438191127e631c8*****";//#New 
        public static readonly string FlutterWaveEncryptionKey = "FLWSECK_TEST298f1****";//#New  
        //********************************************************* 

        //########################################### 
        //Chat
        //*********************************************************  
        public static readonly InitializeWoWonder.ConnectionType ConnectionTypeChat = InitializeWoWonder.ConnectionType.Socket;
        public static readonly string PortSocketServer = "449";
        public static readonly TransportProtocol Transport = TransportProtocol.Polling;

        //Chat Window Activity >>
        //*********************************************************
        //if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        //Just replace it with this 5 lines of code
        /*
         <uses-permission android:name="android.permission.READ_CONTACTS" />
         <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" /> 
         */
        public static readonly bool ShowButtonContact = true;
        /////////////////////////////////////

        public static readonly ChatTheme ChatTheme = ChatTheme.Default; //#new

        public static readonly bool ShowButtonCamera = true;
        public static readonly bool ShowButtonImage = true;
        public static readonly bool ShowButtonVideo = true;
        public static readonly bool ShowButtonAttachFile = true;
        public static readonly bool ShowButtonColor = true;
        public static readonly bool ShowButtonStickers = true;
        public static readonly bool ShowButtonMusic = true;
        public static readonly bool ShowButtonGif = true;
        public static readonly bool ShowButtonLocation = true;

        public static readonly bool OpenVideoFromApp = true;
        public static readonly bool OpenImageFromApp = true;

        //Record Sound Style & Text 
        public static readonly bool ShowButtonRecordSound = true;

        // Options List Message
        public static readonly bool EnableReplyMessageSystem = true;
        public static readonly bool EnableForwardMessageSystem = true;
        public static readonly bool EnableFavoriteMessageSystem = true;
        public static readonly bool EnablePinMessageSystem = true;
        public static readonly bool EnableReactionMessageSystem = true;

        public static readonly bool ShowNotificationWithUpload = true;

        public static readonly bool EnableSuggestionMessage = true;

        //List Chat >>
        //*********************************************************
        public static readonly bool EnableChatPage = false; //>> Next update 
        public static readonly bool EnableChatGroup = true;

        // Options List Chat
        public static readonly bool EnableChatArchive = true;
        public static readonly bool EnableChatPin = true;
        public static readonly bool EnableChatMute = true;
        public static readonly bool EnableChatMakeAsRead = true;


        // Video/Audio Call Settings >>
        //*********************************************************
        public static readonly EnableCall EnableCall = EnableCall.AudioAndVideo;  //#new
        public static readonly SystemCall UseLibrary = SystemCall.Agora;

        //Last Messages Page >>
        //*********************************************************
        public static readonly bool ShowOnlineOfflineMessage = true;

        public static readonly int MessageRequestSpeed = 4000; // 3 Seconds

        public static readonly ColorMessageTheme ColorMessageTheme = ColorMessageTheme.Default;

        //Settings Page >> General Account
        public static readonly bool ShowSettingsWallpaper = true;

        //Options chat heads (Bubbles) 
        //*********************************************************
        public static readonly bool ShowChatHeads = false;
        public static readonly bool ShowSettingsFingerprintLock = true;

        //Always , Hide , FullScreen
        public static readonly string DisplayModeSettings = "Always";

        //Default , Left  , Right , Nearest , Fix , Thrown
        public static readonly string MoveDirectionSettings = "Right";

        //Circle , Rectangle
        public static readonly string ShapeSettings = "Circle";

        // Last position
        public static readonly bool IsUseLastPosition = true;

    }
}