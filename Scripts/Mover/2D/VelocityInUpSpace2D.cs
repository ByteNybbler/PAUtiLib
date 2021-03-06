﻿// Author(s): Paul Calande
// A class with which to read and write velocity
// while taking the up direction into account.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityInUpSpace2D
{
    //[SerializeField]
    [Tooltip("The component with which to read and write velocity.")]
    Mover2D mover;
    //[SerializeField]
    [Tooltip("The up direction.")]
    UpDirection2D upDirection;

    public VelocityInUpSpace2D(Mover2D mover, UpDirection2D upDirection)
    {
        this.mover = mover;
        this.upDirection = upDirection;
    }

    // Retrieves the GameObject's velocity relative to up space.
    public Vector2 GetVelocity()
    {
        return upDirection.SpaceEnter(mover.GetVelocity());
    }

    public float GetVelocityX()
    {
        return GetVelocity().x;
    }

    public float GetVelocityY()
    {
        return GetVelocity().y;
    }

    // Sets the GameObject's velocity relative to up space.
    public void SetVelocity(Vector2 vel)
    {
        mover.SetVelocity(upDirection.SpaceExit(vel));
    }
}