using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;




namespace MTGListerSorter
{
	#region Enums
	public enum ERarity
	{
		Basic_Land,
		Common,
		Uncommon,
		Rare,
		Mythic,
		Timeshifted,
		Masterpiece,
	}

	public enum EType
	{
		Artifact,
		Creature,
		Enchantment,
		Instant,
		Sorcery,
		Land,
		Planeswalker,
	}

	public enum EColour
	{
		INVALID,
		White,
		Blue,
		Black,
		Red,
		Green,
	}

	public enum EVariation
	{
		Foiled,
		Alternative_Artwork,
		Full_Artwork,
		Borderless,
		Promotional,
	}

	public enum ELanguage
	{
		Unknown,
		EN,
		PT,
		ES,
		FR,
		JP,
		RU,
		PL,
	}

	public class ENumConverters
	{
		public static string printERarity(ERarity rarity)
		{
			return Enum.GetName(typeof(ERarity), rarity);
		}
		public static ERarity getERarityStr(string str) { return getEnumFromStr<ERarity>(str); }

		public static string printEType(EType type)
		{
			return Enum.GetName(typeof(EType), type);
		}
		public static EType getETypeStr(string str) { return getEnumFromStr<EType>(str); }

		public static string printEColour(EColour colour)
		{
			return Enum.GetName(typeof(EColour), colour);
		}
		public static EColour getEColourStr(string str) { return getEnumFromStr<EColour>(str); }

		public static string printEVariation(EVariation variation)
		{
			return Enum.GetName(typeof(EVariation), variation);
		}
		public static EVariation getEVariationStr(string str) { return getEnumFromStr<EVariation>(str); }

		public static string printELanguage(ELanguage language)
		{
			return Enum.GetName(typeof(ELanguage), language);
		}
		public static ELanguage getELanguageStr(string str) { return getEnumFromStr<ELanguage>(str); }

		private static T getEnumFromStr<T>(string str)
		{
			dynamic enu = Enum.Parse(typeof(T), str);
			return enu;
		}
	}
	#endregion

	#region AuxStructures
	public struct EditionStruct
	{
		public uint id;
		public string name;
		public string representation;
		public uint month;
		public uint year;

		public void ClearEdition()
		{
			id = 0;
			name = "";
			representation = "";
			month = 0;
			year = 0;
		}

		public static EditionStruct getEditionFromList(uint id, List<EditionStruct> editionList)
        {
			if(editionList.Count>0)
            {
				foreach(dynamic editon in editionList)
                {
					if (editon.id == id) return editon;
                }
            }

			EditionStruct retEd=new EditionStruct();
			retEd.ClearEdition();
			return retEd;
        }
	}

	public struct SubTypeStruct
	{
		public uint id;
		public string name;
		public List<EType> typeBelongsTo;

		public void ClearSubType()
		{
			id = 0;
			name = "";
			if (typeBelongsTo == null) typeBelongsTo = new List<EType>();
			typeBelongsTo.Clear();
		}
	}

	public struct ComplexTypeStruct
	{
		public EType type;
		public List<uint> subTypes;

		public void ClearComplexType(EType _type)
		{
			type = _type;
			if (subTypes == null) subTypes = new List<uint>();
			subTypes.Clear();
		}

		public string printMainType()
        {
			return ENumConverters.printEType(type);
        }

		public string printSubTypes(List<SubTypeStruct> subTypeList)
		{
			string retSubTypeListstr = "";
			if (subTypes.Count > 0)
			{
				foreach (dynamic subType in subTypeList)
				{
					if (retSubTypeListstr != "") retSubTypeListstr += ", ";
					if (subType.id == subType) retSubTypeListstr += subType.name;
				}
			}

			return retSubTypeListstr;
		}

		public string printFullType(List<SubTypeStruct> subTypeList)
        {
			string retTypeStr = printMainType();

			string subTypeStr = printSubTypes(subTypeList);
			if (subTypeStr != "")
			{
				retTypeStr += '(' + subTypeStr + ')';
			}
			return retTypeStr;
		}
	}

	public struct StandardEffectStruct
	{
		public uint id;
		public string name;

		public void clearStandardEffect()
        {
			id = 0;
			name = "";
        }

		public static StandardEffectStruct getStandardEffect(uint id, List<StandardEffectStruct> stdEffectList)
        {
			if(stdEffectList.Count>0)
            {
				foreach(dynamic effect in stdEffectList)
                {
					if (id == effect.id) return effect;
                }
            }

			StandardEffectStruct stdEffect = new StandardEffectStruct();
			stdEffect.clearStandardEffect();
			return stdEffect;
        }
	}

	public struct LocationStruct
    {
		public uint id;
		public string name;
		public uint numberplacing;
		public bool hasNumberPlacing;
		public bool reorderNumberPlacingWhenSorting;

		public void ClearLocation()
        {
			id = 0;
			name = "";
			numberplacing = 0;
			hasNumberPlacing = false;
			reorderNumberPlacingWhenSorting = false;
        }

		public string printLocation()
        {
			return name + (hasNumberPlacing ? " - " + numberplacing.ToString() : "");
		}

		public static LocationStruct getLocation(uint id, List<LocationStruct> locationList)
        {
			foreach (dynamic loc in locationList)
			{
				if (loc.id == id)
				{
					return loc;
				}
			}

			LocationStruct location = new LocationStruct();
			location.ClearLocation();
			return location;
		}
	}
    #endregion

    public struct CardEntryStruct
	{
		public uint id;
		public string name;
		public uint editionID;
		public ERarity rarity;
		public List<ComplexTypeStruct> types;
		public List<EColour> colourSet;
		public uint manaCost;
		public List<EVariation> variation;
		public uint numberOfCards;
		public ELanguage language;
		public float value;
		public uint reservedLocationID;
		public List<uint> currentLocationIDs;
		public List<uint> standardEffectsID;

		public void ClearCardEntry()
        {
			name = "";
			editionID = 0;
			rarity = ERarity.Common;

			if (types == null) types = new List<ComplexTypeStruct>();
			types.Clear();

			if (colourSet == null) colourSet = new List<EColour>();
			colourSet.Clear();

			manaCost = uint.MaxValue;

			if (variation == null) variation = new List<EVariation>();
			variation.Clear();

			numberOfCards = 0;
			language = ELanguage.Unknown;
			value = 0;
			reservedLocationID = 0;
			if (currentLocationIDs == null) currentLocationIDs = new List<uint>();
			currentLocationIDs.Clear();

			if (standardEffectsID == null) standardEffectsID = new List<uint>();
			standardEffectsID.Clear();
		}

		public void copy(CardEntryStruct entry)
        {
			Copy(ref this, entry);
        }

		public static void Copy(ref CardEntryStruct entry1,CardEntryStruct entry2)
        {
			entry1.id = entry2.id;
			entry1.name = entry2.name;
			entry1.editionID = entry2.editionID;
			entry1.rarity = entry2.rarity;
			entry1.types = new List<ComplexTypeStruct>(entry2.types);
			entry1.colourSet = new List<EColour>(entry2.colourSet);
			entry1.manaCost = entry2.manaCost;
			entry1.variation = new List<EVariation>(entry2.variation);
			entry1.numberOfCards = entry2.numberOfCards;
			entry1.language = entry2.language;
			entry1.value = entry2.value;
			entry1.reservedLocationID = entry2.reservedLocationID;
			entry1.currentLocationIDs = new List<uint>(entry2.currentLocationIDs);
			entry1.standardEffectsID = new List<uint>(entry2.standardEffectsID);
        }

        #region Print Elements
        public string printName()
		{
			return name;
		}

        #region Print Edition
        private EditionStruct getEdition(List<EditionStruct> editionList)
        {
			return EditionStruct.getEditionFromList(editionID, editionList);
		}

		public string printEditionShort(List<EditionStruct> editionList)
		{
			return getEdition(editionList).representation;
		}

		public string printEditionName(List<EditionStruct> editionList)
		{
			return getEdition(editionList).name;
		}
        #endregion

		public string printRarity()
        {
			return ENumConverters.printERarity(rarity);
		}

		public string printTypes(List<SubTypeStruct> subTypeList)
		{
			string retTypeStr = "";
			foreach(dynamic complexType in types)
            {
				if (retTypeStr != "") retTypeStr += ", ";

				retTypeStr += complexType.printFullType(subTypeList);
			}
			return retTypeStr;
		}

		public string printColourSet()
        {
			return ManaConverter.ColourListToString(colourSet);
		}

		public string printManaCost()
		{
			return ManaConverter.ConvertManaCost(manaCost);
		}

		public string printCardVariation()
        {
			string retVariation = "";

			if(variation!=null && variation.Count>0)
            {
				foreach(dynamic rotVar in variation)
				{
					if (retVariation != "")
					{
						retVariation += ", ";
					}

					retVariation += ENumConverters.printEVariation(rotVar);
                }
            }

			return retVariation;
        }

		public string printNumberOfCards()
        {
			return numberOfCards.ToString();
		}

		public string printLanguage()
		{
			return ENumConverters.printELanguage(language);
		}

		public string printValue()
        {
			return value.ToString() + '€';
        }

		public string printReservedLocation(List<LocationStruct> locationList)
		{
			return LocationStruct.getLocation(reservedLocationID, locationList).printLocation();
		}

		public string printCurrentLocation(List<LocationStruct> locationList)
		{
			string retLocationList = "";

			foreach(uint id in currentLocationIDs)
            {
				retLocationList += LocationStruct.getLocation(id, locationList).printLocation();
			}
			return retLocationList;
		}

		public string printStdEffects(List<StandardEffectStruct> stdEffectList)
        {
			string retEffectsStr = "";

			if (standardEffectsID.Count > 0)
			{
				standardEffectsID.Sort();
				foreach (dynamic effectID in standardEffectsID)
				{
					StandardEffectStruct.getStandardEffect(effectID, stdEffectList);
				}
			}

			return retEffectsStr;

		}
        #endregion
    }

    class ManaConverter
	{
		static char ColourToChar(EColour colour)
		{
			switch (colour)
			{
				case EColour.White:
					return 'W';
				case EColour.Blue:
					return 'U';
				case EColour.Black:
					return 'B';
				case EColour.Red:
					return 'R';
				case EColour.Green:
					return 'G';
			}
			return 'X';
		}

		static EColour CharToColour(char colourChar)
		{
			switch (colourChar)
			{
				case 'W':
					return EColour.White;
				case 'U':
					return EColour.Blue;
				case 'B':
					return EColour.Black;
				case 'R':
					return EColour.Red;
				case 'G':
					return EColour.Green;
			}

			return EColour.INVALID;
		}

		public static string ColourListToString(List<EColour> colourList)
        {
			string retVal = "";

			foreach (var colour in colourList)
			{
				var colourChar = ColourToChar(colour);
				if (colourChar == 'X') continue;
				retVal += colourChar;
			}

			return retVal;
        }

		public static string ConvertManaCost(uint manaCost)
        {
			if (manaCost == uint.MaxValue) return "";
			return manaCost.ToString();
		}
	}

    #region Storing Elements
    class StoringElement <T>
    {
		public static uint getEntryMaxID()
        {
			return entryMaxID;
        }

		public static T[] getEntryList()
        {
			if (entryList == null) InitEntyList();
			return entryList.ToArray();
        }

		protected static void InitEntyList()
        {
			if (entryList == null) entryList = new List<T>();
			entryList.Clear();
        }

		protected static uint entryMaxID = 0;
		protected static List<T> entryList;
    }

	class StoringCardEntryElement : StoringElement<CardEntryStruct>
	{
		public static void addToList(CardEntryStruct entry)
		{
			if (entryList == null) InitEntyList();
			entryList.Add(entry);
			if (entryMaxID < entry.id) entryMaxID = entry.id;
		}

		public static void removeFromList(uint id)
		{
			if (entryList == null) InitEntyList();
			if (id > 0)
			{
				foreach (dynamic entry in entryList)
				{
					if (entry.id == id)
					{
						entryList.Remove(entry);
						return;
					}
				}
			}
		}

		public static void replaceFromList(CardEntryStruct entry)
		{
			if (entryList == null) InitEntyList();
			if (entry.id > 0)
			{
				for (int index=0;index<entryList.Count;index++)
				{
					if (entry.id == entryList[index].id)
					{
						entryList[index] = entry;
						return;
					}
				}
			}
		}
	}
	class StoringEditionElement : StoringElement<EditionStruct>
	{
		public static void addToList(EditionStruct entry)
		{
			if (entryList == null) InitEntyList();
			entryList.Add(entry);
			if (entryMaxID < entry.id) entryMaxID = entry.id;
		}

		public static void removeFromList(uint id)
		{
			if (entryList == null) InitEntyList();
			if (id > 0)
			{
				foreach (dynamic entry in entryList)
				{
					if (entry.id == id)
					{
						entryList.Remove(entry);
						return;
					}
				}
			}
		}

		public static void replaceFromList(EditionStruct entry)
		{
			if (entryList == null) InitEntyList();
			if (entry.id > 0)
			{
				for (int index = 0; index < entryList.Count; index++)
				{
					if (entry.id == entryList[index].id)
					{
						entryList[index] = entry;
						return;
					}
				}
			}
		}
	}
	class StoringSubTypeElement : StoringElement<SubTypeStruct>
	{
		public static void addToList(SubTypeStruct entry)
		{
			if (entryList == null) InitEntyList();
			entryList.Add(entry);
			if (entryMaxID < entry.id) entryMaxID = entry.id;
		}

		public static void removeFromList(uint id)
		{
			if (entryList == null) InitEntyList();
			if (id > 0)
			{
				foreach (dynamic entry in entryList)
				{
					if (entry.id == id)
					{
						entryList.Remove(entry);
						return;
					}
				}
			}
		}

		public static void replaceFromList(SubTypeStruct entry)
		{
			if (entryList == null) InitEntyList();
			if (entry.id > 0)
			{
				for (int index = 0; index < entryList.Count; index++)
				{
					if (entry.id == entryList[index].id)
					{
						entryList[index] = entry;
						return;
					}
				}
			}
		}
	}
	class StoringStandardEffectElement : StoringElement<StandardEffectStruct>
	{
		public static void addToList(StandardEffectStruct entry)
		{
			entryList.Add(entry);
			if (entryMaxID < entry.id) entryMaxID = entry.id;
		}

		public static void removeFromList(uint id)
		{
			if (id > 0)
			{
				foreach (dynamic entry in entryList)
				{
					if (entry.id == id)
					{
						entryList.Remove(entry);
						return;
					}
				}
			}
		}

		public static void replaceFromList(StandardEffectStruct entry)
		{
			if (entry.id > 0)
			{
				for (int index = 0; index < entryList.Count; index++)
				{
					if (entry.id == entryList[index].id)
					{
						entryList[index] = entry;
						return;
					}
				}
			}
		}
	}
	class StoringLocationElement : StoringElement<LocationStruct>
	{
		public static void addToList(LocationStruct entry)
		{
			entryList.Add(entry);
			if (entryMaxID < entry.id) entryMaxID = entry.id;
		}

		public static void removeFromList(uint id)
		{
			if (id > 0)
			{
				foreach (dynamic entry in entryList)
				{
					if (entry.id == id)
					{
						entryList.Remove(entry);
						return;
					}
				}
			}
		}

		public static void replaceFromList(LocationStruct entry)
		{
			if (entry.id > 0)
			{
				for (int index = 0; index < entryList.Count; index++)
				{
					if (entry.id == entryList[index].id)
					{
						entryList[index] = entry;
						return;
					}
				}
			}
		}
	}
    #endregion
}
