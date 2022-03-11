<H1> Simple tips </H1>

You can reference your gameobjects in the debug.log call
```
Debug.Log(“This is the gameObject calling the debug log”, gameObject);
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
