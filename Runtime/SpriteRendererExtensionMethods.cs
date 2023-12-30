using System.Collections.Generic;
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

        public static void SetSizeX( this SpriteRenderer self, float x )
        {
            var size = self.size;
            size.x    = x;
            self.size = size;
        }

        public static void SetSizeY( this SpriteRenderer self, float y )
        {
            var size = self.size;
            size.y    = y;
            self.size = size;
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

        public static Rect  GetLocalEdge( this   SpriteRenderer self ) => new( self.transform.localPosition, self.bounds.size );
        public static float GetLocalLeft( this   SpriteRenderer self ) => self.transform.localPosition.x - self.bounds.size.x / 2;
        public static float GetLocalRight( this  SpriteRenderer self ) => self.transform.localPosition.x + self.bounds.size.x / 2;
        public static float GetLocalBottom( this SpriteRenderer self ) => self.transform.localPosition.y - self.bounds.size.y / 2;
        public static float GetLocalTop( this    SpriteRenderer self ) => self.transform.localPosition.y + self.bounds.size.y / 2;

        public static void SetColorIfNotNull( this SpriteRenderer self, in Color color )
        {
            if ( self == null ) return;
            self.color = color;
        }

        public static void SetColorWithoutAlphaIfNotNull( this SpriteRenderer self, in Color color )
        {
            if ( self == null ) return;

            self.color = new
            (
                r: color.r,
                g: color.g,
                b: color.b,
                a: self.color.a
            );
        }

        public static void SetColor( this IReadOnlyList<SpriteRenderer> self, in Color color )
        {
            foreach ( var x in self )
            {
                x.color = color;
            }
        }
    }
}