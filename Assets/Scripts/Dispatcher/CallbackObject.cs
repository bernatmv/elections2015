using UnityEngine;
using System;

namespace com.lovelydog 
{
	public class CallbackObject : UnityEngine.Object 
	{
		public Action action;
		public CallbackObject (Action newAction) {
			action = newAction;
		}
	}
}