# 자연어 처리

챗봇에서 메시지 처리를 편하게 해보자는 아이디어부터 시작

## 요약

흔히들 말하는 문맥이라는 개념을 사용하여, 문장이 사용자가 원하는 문맥인지 판별한다.
예를 들어, `알림을 해줘` 라는 문맥을 가진 문장인지 판별한다면 `난 귀엽다` 혹은 `치킨먹고싶다`는 문맥에 옳지 않다. 하지만 `알림 해` 는 문맥에 맞는 문장이다.

## 목표

- [ ] `알림을 해줘` 라는 문맥인지 알 수 있어야 한다.
- [ ] `알림을 하지 말아줘` 처럼 문맥의 반대인지 알 수 있어야 한다.
- [ ] `몇 시에 알림을 해줘` 에서 `몇 시` 같은 문맥의 목적 대상을 가져올 수 있어야 한다.
- [ ] `알림이 있니?` 같은 참/거짓 질문을 처리할 수 있어야 한다.
- [ ] `언제 알림이 있니?` 같은 데이터를 원하는 질문을 처리할 수 있어야 한다.

## 예시

### 목표#1

```csharp
var sentence = parse("알림을 해줘");
var act = sentence.IsMeaningAct("알림");
```

### 목표#2

```csharp
var sentence = parse("알림을 하지 말아줘");
var act = sentence.IsMeaningAct("알림", false);
```

### 목표#3

```csharp
var sentence = parse("2시에 내게 알림을 해줘");
if (sentence.IsMeaningAct("알림"))
{
    var time = sentence.GetActWhen("알림");
    var to = sentence.GetActToWho("알림");
}
```

### 목표#4

```csharp
var sentence = parse("2시에 알림이 있니?");
if (sentence.IsAskingAct("알림", AskingType.BOOL))
{
    var act = sentence.GetAct("알림");
    var result = new Dictionary<string, object>();
    if (act.IsAskingTime())
    {
        result.Add("언제", DateTime.Now);
    }
}
```