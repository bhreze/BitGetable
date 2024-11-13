public interface IBitGetable
{
    bool GetBitByIndex(byte index);
    void SetBitByIndex(byte index, bool value);
}

public class Bits : IBitGetable
{
    public byte Value { get; private set; }

    public Bits(byte value)
    {
        Value = value;
    }

    public Bits(int value)
    {
        Value = (byte)value;
    }

    public Bits(long value)
    {
        Value = (byte)(value % 256);
    }

    public bool GetBitByIndex(byte index)
    {
        return (Value & (1 << index)) != 0;
    }
    public void SetBitByIndex(byte index, bool value)
    {
        if (value)
        {
            Value |= (byte)(1 << index);
        }
        else
        {
            Value = (byte)~(1 << index);
        }
    }
    public bool this[byte index]
    {
        get => GetBitByIndex(index);
        set => SetBitByIndex(index, value);
    }

    public static implicit operator byte(Bits bits) => bits.Value;
    public static explicit operator Bits(byte value) => new Bits(value);

    public static implicit operator int(Bits bits) => (int)bits.Value;
    public static explicit operator Bits(int value) => new Bits((byte)value);

    public static implicit operator long(Bits bits) => (long)(int)bits.Value;
    public static explicit operator Bits(long value) => new Bits((byte)(value % 256));
}
