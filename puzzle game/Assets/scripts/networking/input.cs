using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PubNubAPI;


public class input : MonoBehaviour
{
    public GameObject videoPlayer;

    public static PubNub dataServer;
    public string pubKey = "pub-c-a3c19595-3a8c-4f33-ba69-3f4b1fcf98b3";
    public string subKey = "sub-c-2ce71aa2-1363-11e9-b735-ca3a04aa6aa9";
    public string channelName = "counting";


    public int yesTotal;		
    public int noTotal;

    public int currentVote;
    public int inVote;

    void Start()
    {
        videoPlayer.SetActive(false);


        PNConfiguration connectionSettings = new PNConfiguration();
        connectionSettings.PublishKey = pubKey;
        connectionSettings.SubscribeKey = subKey;
        connectionSettings.LogVerbosity = PNLogVerbosity.BODY;
        connectionSettings.Secure = true;
        ////////

        dataServer = new PubNub(connectionSettings);  

        Debug.Log("Connected to Pubnub");

 
        dataServer.Subscribe()
          .Channels(new List<string>() { channelName })
          .Execute();
        //// when message arrives://///////

        dataServer.SusbcribeCallback += (sender, evt) =>
        {

            SusbcribeEventEventArgs inMessage = evt as SusbcribeEventEventArgs;

            if (inMessage.MessageResult != null)    
            {

                Dictionary<string, object> msg = inMessage.MessageResult.Payload as Dictionary<string, object>;

                inVote = (int)msg["totalHits"];

            
                    if (inVote>currentVote)
                    {
                        videoPlayer.SetActive(true);
                    currentVote = inVote;
                    }
             

            }

        };


    }

}
