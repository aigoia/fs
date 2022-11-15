namespace fs

    open UnityEngine
    
    module Fruit =
        type FruitName = Apple = 0 | Banana = 1 | Melon = 2 
        type FruitColor = Red = 0 | Yellow = 1 | Green = 2 | Black = 3
        type FruitItem =
            struct
                val Name : FruitName 
                val Color : FruitColor
                new(name, color) = { Name = name; Color = color }        
            end
        let fruitList = [FruitItem(FruitName.Apple, FruitColor.Red)
                         FruitItem(FruitName.Banana, FruitColor.Yellow)
                         FruitItem(FruitName.Melon, FruitColor.Green)]
        let mutable currentFruitList  = [FruitItem(FruitName.Apple, FruitColor.Red)]
        let FruitTest =
            if fruitList = [] then Debug.Log "Empty"
            else
                let nonAppleList = fruitList |> List.filter (fun i -> i.Name <> FruitName.Apple)
                let appleList = fruitList |> List.filter (fun i -> i.Name = FruitName.Apple)
                let newFruitList = fruitList |> List.append [FruitItem(FruitName.Apple, FruitColor.Green)]
                currentFruitList <- newFruitList
                
                // for item in nonAppleList do Debug.Log (item.Name)
                // for item in appleList do Debug.Log (item.Name)
                // for item in newFruitList do Debug.Log (item.Name)
                
    open Fruit
    
    type GameManager() =
        inherit MonoBehaviour()
        member this.Start() =
            
            let printFruit item = Debug.Log item 
           
            FruitTest
            let _ = currentFruitList |> List.filter (fun i -> i.Name = FruitName.Apple)
                                     |> List.map  (fun i -> Debug.Log i.Color)
            
            Debug.Log "Hello world"
        member this.testList = []
        
    