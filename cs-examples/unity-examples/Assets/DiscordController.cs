using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour {

	public Discord.Discord discord;

	
	void Start () {
        
		discord = new Discord.Discord(123456789012345678, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
		var activityManager = discord.GetActivityManager();
		var activity = new Discord.Activity
		{
			// Details is the first text and State is the second
			Details = "Details",
			State = "State",
			// Assets allow addition of Images and Alt text
			Assets = {
				LargeImage = "LargeImageName",
				SmallImage = "SmallImageName",
				LargeText = "LargeImageAltText"
				SmallText = "SmallImageAltText"
			}
		};
		activityManager.UpdateActivity(activity, (res) =>
		{
			if (res == Discord.Result.Ok)
				Debug.Log("Discord Status Set!");
		});
	}
	
	void Update () {
		discord.RunCallbacks();
	}

}
