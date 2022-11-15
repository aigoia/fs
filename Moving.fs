namespace fs
    open System.Collections
    open UnityEngine

    type MovingCube() =
        inherit MonoBehaviour()

        member this.Start() =
            this.KeepGoing()

        member this.KeepGoing() =
            let waitTime = 1f
            let speed = 6f
            let distance = 3f
            let target = this.transform.position + Vector3.up * distance
            let mutable isKeep = true
            
            seq {
                while isKeep do
                    
                    this.transform.position <- Vector3.MoveTowards(this.transform.position, target, speed * Time.deltaTime)
                    if this.transform.position = target then isKeep <- false 
                    
                    yield()
                    
            } :?> IEnumerator