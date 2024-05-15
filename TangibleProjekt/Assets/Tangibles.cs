using System.Collections;
using System.Collections.Generic;
using System;
using TuioNet.Tuio11;
using TuioUnity.Common;
using UnityEngine;
using TuioUnity.Tuio11; // Import the Tuio11 namespace
using TuioNet.Common;

public class Tangibles : MonoBehaviour, ITuio11Listener// Implement the ITuio11Listener interface
{
    private Tuio11Manager tuioManager; // Reference to the TUIO 1.1 manager

    void Start()
    {
        // Get the reference to the TUIO 1.1 manager instance
        tuioManager = Tuio11Manager.Instance;

        // Add this script as a TUIO 1.1 listener
        tuioManager.AddTuio11Listener(this);
    }

    // Implement the method from ITuio11Listener interface to handle the addition of tangible objects
    public void AddTuioObject(Tuio11Object tuio11Object)
    {
        // Check if the tangible object ID is 1 (assuming it's the ID of the tangible you want to detect)
        if (tuio11Object.SymbolId == 1)
        {
            // Rotate the game object to the right by 90 degrees
            transform.Rotate(Vector3.forward, 90f);
        }
    }

    // Implement other ITuio11Listener interface methods (not needed for this example)
    public void UpdateTuioObject(Tuio11Object tuio11Object) { }
    public void RemoveTuioObject(Tuio11Object tuio11Object) { }
    public void AddTuioCursor(Tuio11Cursor tuio11Cursor) { }
    public void UpdateTuioCursor(Tuio11Cursor tuio11Cursor) { }
    public void RemoveTuioCursor(Tuio11Cursor tuio11Cursor) { }
    public void AddTuioBlob(Tuio11Blob tuio11Blob) { }
    public void UpdateTuioBlob(Tuio11Blob tuio11Blob) { }
    public void RemoveTuioBlob(Tuio11Blob tuio11Blob) { }
    public void Refresh(TuioTime tuioTime) { }

    // Make sure to remove the listener when this script is destroyed
    void OnDestroy()
    {
        tuioManager.RemoveTuio11Listener(this);
    }

    void ITuio11Listener.AddTuioObject(Tuio11Object tuio11Object)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.UpdateTuioObject(Tuio11Object tuio11Object)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.RemoveTuioObject(Tuio11Object tuio11Object)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.AddTuioCursor(Tuio11Cursor tuio11Cursor)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.UpdateTuioCursor(Tuio11Cursor tuio11Cursor)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.RemoveTuioCursor(Tuio11Cursor tuio11Cursor)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.AddTuioBlob(Tuio11Blob tuio11Blob)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.UpdateTuioBlob(Tuio11Blob tuio11Blob)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.RemoveTuioBlob(Tuio11Blob tuio11Blob)
    {
        throw new NotImplementedException();
    }

    void ITuio11Listener.Refresh(TuioTime tuioTime)
    {
        throw new NotImplementedException();
    }
}
