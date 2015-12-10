using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace com.lovelydog 
{
	public sealed class World {

		// private properties
		private static readonly World _instance = new World();
		// public world properties

		// private methods

		// public methods
		public static World Instance {
			get { return _instance; }
		}
	}
}