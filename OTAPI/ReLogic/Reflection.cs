using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#nullable disable
namespace ReLogic.Reflection;

public class IdDictionary
{
  public readonly Dictionary<string, int> _nameToId = new Dictionary<string, int>();
  public Dictionary<int, string> _idToName;
  public readonly int Count;

  public IEnumerable<string> Names => (IEnumerable<string>) this._nameToId.Keys;

  public IdDictionary(int count) => this.Count = count;

  public bool TryGetName(int id, out string name) => this._idToName.TryGetValue(id, out name);

  public bool TryGetId(string name, out int id) => this._nameToId.TryGetValue(name, out id);

  public bool ContainsName(string name) => this._nameToId.ContainsKey(name);

  public bool ContainsId(int id) => this._idToName.ContainsKey(id);

  public string GetName(int id) => this._idToName[id];

  public int GetId(string name) => this._nameToId[name];

  public void Add(string name, int id)
  {
    this._idToName.Add(id, name);
    this._nameToId.Add(name, id);
  }

  public void Remove(string name)
  {
    this._idToName.Remove(this._nameToId[name]);
    this._nameToId.Remove(name);
  }

  public void Remove(int id)
  {
    this._nameToId.Remove(this._idToName[id]);
    this._idToName.Remove(id);
  }

  public static IdDictionary Create(Type idClass, Type idType)
  {
    int count = int.MaxValue;
    FieldInfo fieldInfo = ((IEnumerable<FieldInfo>) idClass.GetFields()).FirstOrDefault<FieldInfo>((Func<FieldInfo, bool>) (field => field.Name == "Count"));
    if (fieldInfo != (FieldInfo) null)
    {
      count = Convert.ToInt32(fieldInfo.GetValue((object) null));
      if (count == 0)
        throw new Exception("IdDictionary cannot be created before Count field is initialized. Move to bottom of static class");
    }
    IdDictionary dictionary = new IdDictionary(count);
    ((IEnumerable<FieldInfo>) idClass.GetFields(BindingFlags.Static | BindingFlags.Public)).Where<FieldInfo>((Func<FieldInfo, bool>) (f => f.FieldType == idType)).ToList<FieldInfo>().ForEach((Action<FieldInfo>) (field =>
    {
      int int32 = Convert.ToInt32(field.GetValue((object) null));
      if (int32 >= dictionary.Count)
        return;
      dictionary._nameToId.Add(field.Name, int32);
    }));
    dictionary._idToName = dictionary._nameToId.ToDictionary<KeyValuePair<string, int>, int, string>((Func<KeyValuePair<string, int>, int>) (kp => kp.Value), (Func<KeyValuePair<string, int>, string>) (kp => kp.Key));
    return dictionary;
  }

  public static IdDictionary Create<IdClass, IdType>()
  {
    return IdDictionary.Create(typeof (IdClass), typeof (IdType));
  }
}
