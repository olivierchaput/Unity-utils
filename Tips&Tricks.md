<H1> Simple tips </H1>

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
