# Architecture 

## Goals

- Split Logic and Implimentation
- Be able to Unit test logic without Unity
- TDD
- Easy & Fast

`OsuSequence`  - is abstract factory for the `OsuButtons` 
`OsuSequence`  - is also updating all it's buttons on Update

## Tests

### Button

- Don't click button
- Click button OnTime
- Click in Range

- Click out of Range(Exception)


#### Sequence

- Spawning first 3 buttons
- Spawning button after first is clicked

- Clicking button in right order
- Clicking button in wrong order

- Complete sequence
- Not complete sequence


```puml

@startuml

interface IOsuSequence {

  float _timeOut  = 2.00f
  float _sequenceLength  = 2.00f
  float _spawnRange= 2.00f
  float _buttonBitmout = 0.5f;

  public IOSuEntity[] OsuEntities {get;}


  public event Action<IOsuEntity> OnSpawnEntity;

  public event Action<IOsuEntity> OnEntityPass;
  public event Action<IOsuEntity> OnEntityFailed;

  public event Action<IOsuSequence> OnSequenceEnd;

  public void ClickButton(IOsuEntity);

  /// Updting all the Entities it's assign to
  public void Update(float Time);

}

interface IOsuEntity{

  public readonly int Index;
  public readonly float TimeStamp 
  public readonly float TimeRange

  public event Action OnTimeOut;
  /// Return us  value beteen -1 to 1 
  /// representing perefect time 
  /// -1 means to early 
  public event Action<float> OnClick;

  public void Update (float Time)
  public void Click(float Time)

}


abstract class OsuFactory {

  IOsuSequence CreateSequence{}
  IOsuEntity CreateEntity{}

}



IOsuSequence ..> IOsuEntity

OsuFactory ..> IOsuSequence



@enduml

```
## Future Logic

- Rhytm Timing provider
- Health Points
- Unity Integration

```puml

@startuml

abstract class OsuFactory {
  IOsuSequence CreateMatch{}
  IOsuSequence CreateSequence{}
  IOsuEntity CreateEntity{}
}
OsuFactory ..> IOsuSequence
OsuFactory ..> IOsuEntity

interface  IOsuManager {
  void Init();
  void Update(float deltaTime);
  IOsuMatch CurrentMatch(){}
}

class OsuManager {}

interface IOsuMatch {
  IOsuSequence CurrentSequence {get;}
  IOsuSequence GetNextSequence ();
}

@enduml

```


## Far future 

- Check design patterns list and maybe add some
