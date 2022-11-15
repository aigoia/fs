namespace fs
    open UnityEngine
    
    type Hello() =
        inherit MonoBehaviour()
        
            member this.Start() =
                Debug.Log "Hello"
                
