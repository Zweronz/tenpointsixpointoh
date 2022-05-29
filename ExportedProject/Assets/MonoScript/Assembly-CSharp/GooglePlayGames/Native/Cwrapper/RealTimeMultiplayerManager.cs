using System;
using System.Runtime.InteropServices;

namespace GooglePlayGames.Native.Cwrapper
{
	internal static class RealTimeMultiplayerManager
	{
		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_AcceptInvitation(HandleRef self, IntPtr invitation, IntPtr helper, RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_CreateRealTimeRoom(HandleRef self, IntPtr config, IntPtr helper, RealTimeMultiplayerManager.RealTimeRoomCallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_DeclineInvitation(HandleRef self, IntPtr invitation);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_DismissInvitation(HandleRef self, IntPtr invitation);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_FetchInvitations(HandleRef self, RealTimeMultiplayerManager.FetchInvitationsCallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_FetchInvitationsResponse_Dispose(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_GetElement(HandleRef self, UIntPtr index);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern UIntPtr RealTimeMultiplayerManager_FetchInvitationsResponse_GetInvitations_Length(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern CommonErrorStatus.ResponseStatus RealTimeMultiplayerManager_FetchInvitationsResponse_GetStatus(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_LeaveRoom(HandleRef self, IntPtr room, RealTimeMultiplayerManager.LeaveRoomCallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_RealTimeRoomResponse_Dispose(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr RealTimeMultiplayerManager_RealTimeRoomResponse_GetRoom(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern CommonErrorStatus.MultiplayerStatus RealTimeMultiplayerManager_RealTimeRoomResponse_GetStatus(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_RoomInboxUIResponse_Dispose(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr RealTimeMultiplayerManager_RoomInboxUIResponse_GetInvitation(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_RoomInboxUIResponse_GetStatus(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_SendReliableMessage(HandleRef self, IntPtr room, IntPtr participant, byte[] data, UIntPtr data_size, RealTimeMultiplayerManager.SendReliableMessageCallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessage(HandleRef self, IntPtr room, IntPtr[] participants, UIntPtr participants_size, byte[] data, UIntPtr data_size);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_SendUnreliableMessageToOthers(HandleRef self, IntPtr room, byte[] data, UIntPtr data_size);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_ShowPlayerSelectUI(HandleRef self, uint minimum_players, uint maximum_players, bool allow_automatch, RealTimeMultiplayerManager.PlayerSelectUICallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_ShowRoomInboxUI(HandleRef self, RealTimeMultiplayerManager.RoomInboxUICallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_ShowWaitingRoomUI(HandleRef self, IntPtr room, uint min_participants_to_start, RealTimeMultiplayerManager.WaitingRoomUICallback callback, IntPtr callback_arg);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern void RealTimeMultiplayerManager_WaitingRoomUIResponse_Dispose(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern IntPtr RealTimeMultiplayerManager_WaitingRoomUIResponse_GetRoom(HandleRef self);

		[DllImport("gpg", CharSet=CharSet.None, ExactSpelling=false)]
		internal static extern CommonErrorStatus.UIStatus RealTimeMultiplayerManager_WaitingRoomUIResponse_GetStatus(HandleRef self);

		internal delegate void FetchInvitationsCallback(IntPtr arg0, IntPtr arg1);

		internal delegate void LeaveRoomCallback(CommonErrorStatus.ResponseStatus arg0, IntPtr arg1);

		internal delegate void PlayerSelectUICallback(IntPtr arg0, IntPtr arg1);

		internal delegate void RealTimeRoomCallback(IntPtr arg0, IntPtr arg1);

		internal delegate void RoomInboxUICallback(IntPtr arg0, IntPtr arg1);

		internal delegate void SendReliableMessageCallback(CommonErrorStatus.MultiplayerStatus arg0, IntPtr arg1);

		internal delegate void WaitingRoomUICallback(IntPtr arg0, IntPtr arg1);
	}
}