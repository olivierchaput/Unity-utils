<H1> Simple tips </H1>

When starting a project, set a colorful tint in play mode to prevent modifying things in play mode and losing it all

<img src="https://user-images.githubusercontent.com/68881297/157872924-ecc4ebc7-3077-408e-8a18-148b6c770f45.png" width="400">
<img src="https://user-images.githubusercontent.com/68881297/157872904-2da208a2-fd04-4927-88bb-45efdece732c.png" width="400">


You can reference your gameobjects in the debug.log call
```
Debug.Log(“This is the gameObject calling the debug log”, gameObject);
```

Destroy Objects after a set amount of time (Here, it destroys it after 1 second)
```
Destroy(gameObject, 1f);
```

Use String interpolation in debug statements to accelerate and simplify the writing of logs
Here is an example without interpolation
```
Debug.Log("My player's name is " + player.name + " with " + player.health + "/" + player.maxHealth + " health points left.");
```
Here is the same example with interpolation
```
Debug.log($"My player's name is {player.name} with {player.health}/{player.maxHealth} health points left.");
```


<H1> Advanced tips </H1>

To make sur people don't wrongly call your coroutines, you can declare them as a regular function like this
```
private Coroutine DoSomething()
{
  return StartCoroutine(DoSomethingCoroutine());
  
  Enumerator DoSomethingCoroutine()
  {
    yield return null;
  }
}
```
