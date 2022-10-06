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

        public static Vector2 GetSize( this SpriteRenderer self )
        {
            return new Vector2( self.GetWidth(), self.GetHeight() );
        }

        public static float GetWidth( this SpriteRenderer self )
        {
            return self.bounds.size.x;
        }

        public static float GetHeight( this SpriteRenderer self )
        {
            return self.bounds.size.y;
        }

        public static Rect GetWorldEdge( this SpriteRenderer self )
        {
            return new
            (
                position: self.transform.position,
                size: self.bounds.size
            );
        }

        public static float GetWorldLeft( this SpriteRenderer self )
        {
            return self.transform.position.x - self.bounds.size.x / 2;
        }

        public static float GetWorldRight( this SpriteRenderer self )
        {
            return self.transform.position.x + self.bounds.size.x / 2;
        }

        public static float GetWorldBottom( this SpriteRenderer self )
        {
            return self.transform.position.y - self.bounds.size.y / 2;
        }

        public static float GetWorldTop( this SpriteRenderer self )
        {
            return self.transform.position.y + self.bounds.size.y / 2;
        }
    }
}