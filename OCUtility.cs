 using UnityEngine;
 
 public static class OCUtils
 {
   public static void RemoveDebugsInProd()
   {
       //Call this in Awake of every script in order to remove Debug.Log statements in production builds. This will improve global performance 

        #if UNITY_EDITOR
            Debug.unityLogger.logEnabled = true;
        #else
            Debug.unityLogger.logEnabled = false;
        #endif
   }
 }