﻿

//------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a magic.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// ReSharper disable CheckNamespace

namespace TransportTycoon
{
    [DebuggerDisplay("{Location} ({Distance})")]
    internal sealed class Destination: IEquatable<Destination>
    {
        public Destination(TransportTycoon.Location location, uint distance)
        {
            Location = location;
            Distance = distance;
        }

        public TransportTycoon.Location Location { get; }

        public uint Distance { get; }

        #region Equality and Deconstruct Members

        public bool Equals(Destination other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                Equals(Location, other.Location) &&
                Equals(Distance, other.Distance);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Destination);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Location.GetHashCode());
                hashCode = (hashCode * 397) ^ (Distance.GetHashCode());
                return hashCode;
            }
        }

        public void Deconstruct(out TransportTycoon.Location location, out uint distance)
        {
            location = Location;
            distance = Distance;
        }

        #endregion Equality and Deconstruct Members

    }

    [DebuggerDisplay("{VehicleType} —[ {Cargo.ToString()} ]→ {Location}")]
    internal sealed class Waypoint: IEquatable<Waypoint>
    {
        public Waypoint(TransportTycoon.Location location, TransportTycoon.VehicleType vehicleType, char cargo)
        {
            Location = location;
            VehicleType = vehicleType;
            Cargo = cargo;
        }

        public TransportTycoon.Location Location { get; }

        public TransportTycoon.VehicleType VehicleType { get; }

        public char Cargo { get; }

        #region Equality and Deconstruct Members

        public bool Equals(Waypoint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                Equals(Location, other.Location) &&
                Equals(VehicleType, other.VehicleType) &&
                Equals(Cargo, other.Cargo);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Waypoint);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Location.GetHashCode());
                hashCode = (hashCode * 397) ^ (VehicleType.GetHashCode());
                hashCode = (hashCode * 397) ^ (Cargo.GetHashCode());
                return hashCode;
            }
        }

        public void Deconstruct(out TransportTycoon.Location location, out TransportTycoon.VehicleType vehicleType, out char cargo)
        {
            location = Location;
            vehicleType = VehicleType;
            cargo = Cargo;
        }

        #endregion Equality and Deconstruct Members

    }

}

namespace TransportTycoon.Templates
{
    internal sealed class Ship: IEquatable<Ship>
    {
        public Ship(string name, IReadOnlyList<char> cargo, int? position)
        {
            Name = name;
            Cargo = cargo;
            Position = position;
        }

        public string Name { get; }

        public IReadOnlyList<char> Cargo { get; }

        public int? Position { get; }

        #region Equality and Deconstruct Members

        public bool Equals(Ship other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                Equals(Name, other.Name) &&
                Equals(Cargo, other.Cargo) &&
                Equals(Position, other.Position);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Ship);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Cargo.GetHashCode());
                hashCode = (hashCode * 397) ^ (Position != null ? Position.GetHashCode() : 0);
                return hashCode;
            }
        }

        public void Deconstruct(out string name, out IReadOnlyList<char> cargo, out int? position)
        {
            name = Name;
            cargo = Cargo;
            position = Position;
        }

        #endregion Equality and Deconstruct Members

    }

    public sealed class Truck: System.Reflection.Assembly, IEquatable<Truck>
    {
        public Truck(System.Reflection.AssemblyName name)
        {
            Name = name;
        }

        public System.Reflection.AssemblyName Name { get; }

        #region Equality and Deconstruct Members

        public bool Equals(Truck other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Truck);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Name.GetHashCode());
                return hashCode;
            }
        }

        public void Deconstruct(out System.Reflection.AssemblyName name)
        {
            name = Name;
        }

        #endregion Equality and Deconstruct Members

    }

}

namespace TransportTycoon.Templates2
{
    internal sealed class Track: IEquatable<Track>
    {
        public Track(decimal age)
        {
            Age = age;
        }

        public decimal Age { get; }

        #region Equality and Deconstruct Members

        public bool Equals(Track other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                Equals(Age, other.Age);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Track);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ (Age.GetHashCode());
                return hashCode;
            }
        }

        public void Deconstruct(out decimal age)
        {
            age = Age;
        }

        #endregion Equality and Deconstruct Members

    }

}
