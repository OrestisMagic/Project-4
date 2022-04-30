using System;
using GXPEngine; // Allows using Mathf functions

public struct Vec2
{
	public float x;
	public float y;

	public Vec2(float pX = 0, float pY = 0)
	{
		x = pX;
		y = pY;
	}
	public float Length()
	{
		float length;

		length = Mathf.Sqrt(x * x + y * y);
		return length;
	}

	public void Normalize()
	{
		float length = Length();
		if (length != 0)
		{
			x = x / length;
			y = y / length;
		}
	}

	public Vec2 Normalized()
	{
		Vec2 normalizedVec = new Vec2();
		if (Length() != 0)
		{
			normalizedVec.x = x / Length();
			normalizedVec.y = y / Length();
		}
		return normalizedVec;
	}

	public void SetXY(float newX, float newY)
	{
		x = newX;
		y = newY;
	}
	public static float Deg2Rad(float angle)
	{
		return angle * ((float)Mathf.PI / 180);
	}

	public static float Rad2Deg(float angle)
	{
		return angle * (180 / (float)Mathf.PI);
	}

	public static Vec2 GetUnitVectorDeg(float angle)
	{
		return new Vec2((float)Mathf.Cos(Deg2Rad(angle)), (float)Mathf.Sin(Deg2Rad(angle)));
	}

	public static Vec2 GetUnitVectorRad(float angle)
	{
		return new Vec2((float)Mathf.Cos(angle), (float)Mathf.Sin(angle));
	}

	public static Vec2 RandomUnitVector()
	{
		int angle = Utils.Random(0, 360);
		return new Vec2((float)Mathf.Cos(Deg2Rad(angle)), (float)Mathf.Sin(Deg2Rad(angle)));
	}

	public void SetAngleDegrees(float angle)
	{
		float length = Length();
		float dx = length * (float)Mathf.Cos(Deg2Rad(angle));
		float dy = length * (float)Mathf.Sin(Deg2Rad(angle));
		float targetAngle = Mathf.Atan2(dy, dx);
		this = GetUnitVectorRad(targetAngle) * length;
	}

	public void SetAngleRadians(float angle)
	{
		float length = Length();
		float dx = length * (float)Mathf.Cos(angle);
		float dy = length * (float)Mathf.Sin(angle);
		float targetAngle = Mathf.Atan2(dy, dx);
		this = GetUnitVectorRad(targetAngle) * length;
	}

	public float GetAngleRadians()
	{
		return Mathf.Atan2(y, x);
	}
	public float GetAngleDegrees()
	{
		return Rad2Deg(Mathf.Atan2(y, x));
	}

	public void RotateDegrees(float angle)
	{
		angle = Deg2Rad(angle);
		float oldX = x;
		float oldY = y;

		x = oldX * Mathf.Cos(angle) - oldY * Mathf.Sin(angle);
		y = oldX * Mathf.Sin(angle) + oldY * Mathf.Cos(angle);
	}

	public void RotateRadians(float angle)
	{
		float oldX = x;
		float oldY = y;

		x = oldX * Mathf.Cos(angle) - oldY * Mathf.Sin(angle);
		y = oldX * Mathf.Sin(angle) + oldY * Mathf.Cos(angle);
	}

	public void RotateAroundDegrees(Vec2 point, float angle)
	{
		this -= point;
		RotateDegrees(angle);
		this += point;
	}
	public void RotateAroundRadians(Vec2 point, float angle)
	{
		this -= point;
		RotateRadians(angle);
		this += point;
	}
	public float Dot(Vec2 other)
	{
		float dot = this.x * other.x + this.y * other.y;
		return dot;
	}

	public Vec2 Normal()
	{
		Vec2 n = new Vec2(-y, x);
		float length = n.Length();
		n.x /= length;
		n.y /= length;
		return n;
	}

	public void Reflect(Vec2 pNormal, float pBounciness = 1)
	{
		Vec2 vec = this;
		this = vec - (1 + pBounciness) * vec.Dot(pNormal) * pNormal;
	}

	public static Vec2 operator +(Vec2 left, Vec2 right)
	{
		return new Vec2(left.x + right.x, left.y + right.y);
	}

	public static Vec2 operator -(Vec2 left, Vec2 right)
	{
		return new Vec2(left.x - right.x, left.y - right.y);
	}

	public static Vec2 operator *(float left, Vec2 right)
	{
		return new Vec2(left * right.x, left * right.y);
	}
	public static Vec2 operator *(Vec2 right, float left)
	{
		return new Vec2(left * right.x, left * right.y);
	}
	public static Vec2 operator /(Vec2 v, float scalar)
	{
		return new Vec2(v.x / scalar, v.y / scalar);
	}

	public override string ToString()
	{
		return String.Format("({0},{1})", x, y);
	}
}