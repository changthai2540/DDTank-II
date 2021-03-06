using System;
namespace Center.Server
{
	public enum ePackageType
	{
		BUY_BADGE = 160,
		RSAKey = 0,
		LOGIN,
		KITOFF_USER,
		ALLOW_USER_LOGIN,
		USER_OFFLINE,
		USER_ONLINE,
		USER_STATE,
		UPDATE_ASS,
		UPDATE_CONFIG_STATE,
		CHARGE_MONEY,
		SCENE_CHAT = 19,
		SYS_NOTICE = 10,
		SYS_RELOAD,
		PING,
		UPDATE_PLAYER_MARRIED_STATE,
		MARRY_ROOM_INFO_TO_PLAYER,
		SHUTDOWN,
		CHAT_PERSONAL = 37,
		SYS_MESS,
		B_BUGLE = 72,
		MAIL_RESPONSE = 117,
		CONSORTIA_RESPONSE = 128,
		CONSORTIA_CREATE = 130,
		CONSORTIA_DELETE,
		CONSORTIA_ALLY_ADD = 147,
		CONSORTIA_CHAT = 155,
		CONSORTIA_OFFER,
		CONSORTIA_RICHES,
		CONSORTIA_FIGHT,
		CONSORTIA_UPGRADE,
		FRIEND_STATE = 165,
		FRIEND_RESPONSE,
		Rate = 177,
		MACRO_DROP,
		IP_PORT = 240
	}
}
