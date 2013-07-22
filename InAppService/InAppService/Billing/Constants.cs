using System;

namespace InAppService
{
	public sealed class BillingResult{
		private BillingResult ()
		{
			
		}

		/// <summary>
		/// Success
		/// </summary>
		/// <value>Success - 0</value>
		public static int OK{
			get{
				return 0;
			}
		}

		/// <summary>
		/// User pressed back or canceled a dialog
		/// </summary>
		/// <value>The user cancelled - 1</value>
		public static int UserCancelled{
			get{
				return 1;
			}
		}

		/// <summary>
		/// this billing API version is not supported for the type requested
		/// </summary>
		/// <value>The billing unavailable - 3</value>
		public static int BillingUnavailable{
			get{
				return 3;
			}
		}

		/// <summary>
		/// Requested SKU is not available for purchase
		/// </summary>
		/// <value>The item unavailable - 4</value>
		public static int ItemUnavailable{
			get{
				return 4;
			}
		}

		/// <summary>
		/// Invalid arguments provided to the API
		/// </summary>
		/// <value>The developer error - 5</value>
		public static int DeveloperError{
			get{
				return 5;
			}
		}

		/// <summary>
		/// Fatal error during the API action
		/// </summary>
		/// <value>The error - 6</value>
		public static int Error{
			get{
				return 6;
			}
		}

		/// <summary>
		/// Failure to purchase since item is already owned
		/// </summary>
		/// <value>The item already owned - 7</value>
		public static int ItemAlreadyOwned{
			get{
				return 7;
			}
		}

		/// <summary>
		/// Failure to consume since item is not owned
		/// </summary>
		/// <value>The item not owned - 8</value>
		public static int ItemNotOwned{
			get{
				return 8;
			}
		}
	}

	/// <summary>
	/// In app billing item types.
	/// </summary>
	public sealed class ItemType{

		/// <summary>
		/// Gets the in app Item type
		/// </summary>
		/// <value>inapp</value>
		public static string InApp{
			get{
				return "inapp";
			}
		}

		/// <summary>
		/// Gets the subscription type
		/// </summary>
		/// <value>subs</value>
		public static string Subscription{
			get{
				return "subs";
			}
		}
	}

	public sealed class Constants{
		private Constants() {}

		public static int APIVersion{
			get{
				return 3;
			}
		}

		public static string SkuDetailsList{
			get{
				return "DETAILS_LIST";
			}
		}

		public static string ItemIdList{
			get{
				return "ITEM_ID_LIST";
			}
		}

		public static string BuyItem{
			get{
				return "BUY_INTENT";
			}
		}
	}
}
