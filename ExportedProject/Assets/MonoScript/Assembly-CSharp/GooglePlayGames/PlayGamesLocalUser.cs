using System;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, IUserProfile, ILocalUser
	{
		[CompilerGenerated]
		private sealed class _003CGetStats_003Ec__AnonStorey1F7
		{
			internal Action<CommonStatusCodes, PlayerStats> callback;

			internal PlayGamesLocalUser _003C_003Ef__this;

			internal void _003C_003Em__7A(CommonStatusCodes rc, PlayerStats stats)
			{
				_003C_003Ef__this.mStats = stats;
				callback(rc, stats);
			}
		}

		internal PlayGamesPlatform mPlatform;

		private string emailAddress;

		private PlayerStats mStats;

		public IUserProfile[] friends
		{
			get
			{
				return mPlatform.GetFriends();
			}
		}

		public bool authenticated
		{
			get
			{
				return mPlatform.IsAuthenticated();
			}
		}

		public bool underage
		{
			get
			{
				return true;
			}
		}

		public new string userName
		{
			get
			{
				string text = string.Empty;
				if (authenticated)
				{
					text = mPlatform.GetUserDisplayName();
					if (!base.userName.Equals(text))
					{
						ResetIdentity(text, mPlatform.GetUserId(), mPlatform.GetUserImageUrl());
					}
				}
				return text;
			}
		}

		public new string id
		{
			get
			{
				string text = string.Empty;
				if (authenticated)
				{
					text = mPlatform.GetUserId();
					if (!base.id.Equals(text))
					{
						ResetIdentity(mPlatform.GetUserDisplayName(), text, mPlatform.GetUserImageUrl());
					}
				}
				return text;
			}
		}

		[Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
		public string accessToken
		{
			get
			{
				return (!authenticated) ? string.Empty : mPlatform.GetAccessToken();
			}
		}

		public new bool isFriend
		{
			get
			{
				return true;
			}
		}

		public new UserState state
		{
			get
			{
				return UserState.Online;
			}
		}

		public new string AvatarURL
		{
			get
			{
				string text = string.Empty;
				if (authenticated)
				{
					text = mPlatform.GetUserImageUrl();
					if (!base.id.Equals(text))
					{
						ResetIdentity(mPlatform.GetUserDisplayName(), mPlatform.GetUserId(), text);
					}
				}
				return text;
			}
		}

		public string Email
		{
			get
			{
				if (authenticated && string.IsNullOrEmpty(emailAddress))
				{
					emailAddress = mPlatform.GetUserEmail();
					emailAddress = emailAddress ?? string.Empty;
				}
				return (!authenticated) ? string.Empty : emailAddress;
			}
		}

		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
			: base("localUser", string.Empty, string.Empty)
		{
			mPlatform = plaf;
			emailAddress = null;
			mStats = null;
		}

		public void Authenticate(Action<bool> callback)
		{
			mPlatform.Authenticate(callback);
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
			mPlatform.Authenticate(callback, silent);
		}

		public void LoadFriends(Action<bool> callback)
		{
			mPlatform.LoadFriends(this, callback);
		}

		[Obsolete("Use PlayGamesPlatform.GetServerAuthCode()")]
		public void GetIdToken(Action<string> idTokenCallback)
		{
			if (authenticated)
			{
				mPlatform.GetIdToken(idTokenCallback);
			}
			else
			{
				idTokenCallback(null);
			}
		}

		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
			_003CGetStats_003Ec__AnonStorey1F7 _003CGetStats_003Ec__AnonStorey1F = new _003CGetStats_003Ec__AnonStorey1F7();
			_003CGetStats_003Ec__AnonStorey1F.callback = callback;
			_003CGetStats_003Ec__AnonStorey1F._003C_003Ef__this = this;
			if (mStats == null || !mStats.Valid)
			{
				mPlatform.GetPlayerStats(_003CGetStats_003Ec__AnonStorey1F._003C_003Em__7A);
			}
			else
			{
				_003CGetStats_003Ec__AnonStorey1F.callback(CommonStatusCodes.Success, mStats);
			}
		}
	}
}