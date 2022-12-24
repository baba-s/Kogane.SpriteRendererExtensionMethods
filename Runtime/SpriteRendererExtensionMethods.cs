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

        public static Vector2 GetSize( this       SpriteRenderer self ) => new( self.GetWidth(), self.GetHeight() );
        public static float   GetWidth( this      SpriteRenderer self ) => self.bounds.size.x;
        public static float   GetWidthHalf( this  SpriteRenderer self ) => self.GetWidth() * 0.5f;
        public static float   GetHeight( this     SpriteRenderer self ) => self.bounds.size.y;
        public static float   GetHeightHalf( this SpriteRenderer self ) => self.GetHeight() * 0.5f;

        public static Rect  GetWorldEdge( this   SpriteRenderer self ) => new( self.transform.position, self.bounds.size );
        public static float GetWorldLeft( this   SpriteRenderer self ) => self.transform.position.x - self.bounds.size.x / 2;
        public static float GetWorldRight( this  SpriteRenderer self ) => self.transform.position.x + self.bounds.size.x / 2;
        public static float GetWorldBottom( this SpriteRenderer self ) => self.transform.position.y - self.bounds.size.y / 2;
        public static float GetWorldTop( this    SpriteRenderer self ) => self.transform.position.y + self.bounds.size.y / 2;
    }
}