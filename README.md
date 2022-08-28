# Kogane Sprite Renderer Extension Methods

SpriteRenderer の拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.SetAlpha( 0.5f );
    }
}
```