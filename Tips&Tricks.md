<H3> To make sur people don't wrongly call your coroutines, you can declare them as a regular function like this </H3>


private Coroutine DoSomething()
{
  return StartCoroutine(DoSomethingCoroutine());
  
  Enumerator DoSomethingCoroutine()
  {
    yield return null;
  }
}
```


