using UnityEngine;

namespace Kogane
{
    public static class SpriteRendererExtensionMethods
    {
        public static void SetAlpha( this SpriteRenderer self, float alpha )
        {
            var color = self.color;
            color.a    = alpha;
            self.color = color;
        }
    }
}