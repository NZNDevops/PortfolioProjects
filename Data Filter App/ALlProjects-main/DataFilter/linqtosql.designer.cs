﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataFilter
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FileProcessorDatabase")]
	public partial class linqtosqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserActivit(UserActivit instance);
    partial void UpdateUserActivit(UserActivit instance);
    partial void DeleteUserActivit(UserActivit instance);
    partial void InsertUserFile(UserFile instance);
    partial void UpdateUserFile(UserFile instance);
    partial void DeleteUserFile(UserFile instance);
    #endregion
		
		public linqtosqlDataContext() : 
				base(global::DataFilter.Properties.Settings.Default.FileProcessorDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqtosqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserActivit> UserActivits
		{
			get
			{
				return this.GetTable<UserActivit>();
			}
		}
		
		public System.Data.Linq.Table<UserFile> UserFiles
		{
			get
			{
				return this.GetTable<UserFile>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _NewPassword;
		
		private string _AccountType;
		
		private string _EmailAddress;
		
		private string _DateOfBirth;
		
		private string _Gender;
		
		private int _QuestionNo;
		
		private string _Answer_;
		
		private string _ProfilePicture;
		
		private EntitySet<UserActivit> _UserActivits;
		
		private EntitySet<UserFile> _UserFiles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnNewPasswordChanging(string value);
    partial void OnNewPasswordChanged();
    partial void OnAccountTypeChanging(string value);
    partial void OnAccountTypeChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnDateOfBirthChanging(string value);
    partial void OnDateOfBirthChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnQuestionNoChanging(int value);
    partial void OnQuestionNoChanged();
    partial void OnAnswer_Changing(string value);
    partial void OnAnswer_Changed();
    partial void OnProfilePictureChanging(string value);
    partial void OnProfilePictureChanged();
    #endregion
		
		public User()
		{
			this._UserActivits = new EntitySet<UserActivit>(new Action<UserActivit>(this.attach_UserActivits), new Action<UserActivit>(this.detach_UserActivits));
			this._UserFiles = new EntitySet<UserFile>(new Action<UserFile>(this.attach_UserFiles), new Action<UserFile>(this.detach_UserFiles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewPassword", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string NewPassword
		{
			get
			{
				return this._NewPassword;
			}
			set
			{
				if ((this._NewPassword != value))
				{
					this.OnNewPasswordChanging(value);
					this.SendPropertyChanging();
					this._NewPassword = value;
					this.SendPropertyChanged("NewPassword");
					this.OnNewPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountType", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string AccountType
		{
			get
			{
				return this._AccountType;
			}
			set
			{
				if ((this._AccountType != value))
				{
					this.OnAccountTypeChanging(value);
					this.SendPropertyChanging();
					this._AccountType = value;
					this.SendPropertyChanged("AccountType");
					this.OnAccountTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionNo", DbType="Int NOT NULL")]
		public int QuestionNo
		{
			get
			{
				return this._QuestionNo;
			}
			set
			{
				if ((this._QuestionNo != value))
				{
					this.OnQuestionNoChanging(value);
					this.SendPropertyChanging();
					this._QuestionNo = value;
					this.SendPropertyChanged("QuestionNo");
					this.OnQuestionNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Answer ]", Storage="_Answer_", DbType="NChar(100)")]
		public string Answer_
		{
			get
			{
				return this._Answer_;
			}
			set
			{
				if ((this._Answer_ != value))
				{
					this.OnAnswer_Changing(value);
					this.SendPropertyChanging();
					this._Answer_ = value;
					this.SendPropertyChanged("Answer_");
					this.OnAnswer_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfilePicture", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ProfilePicture
		{
			get
			{
				return this._ProfilePicture;
			}
			set
			{
				if ((this._ProfilePicture != value))
				{
					this.OnProfilePictureChanging(value);
					this.SendPropertyChanging();
					this._ProfilePicture = value;
					this.SendPropertyChanged("ProfilePicture");
					this.OnProfilePictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserActivit", Storage="_UserActivits", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserActivit> UserActivits
		{
			get
			{
				return this._UserActivits;
			}
			set
			{
				this._UserActivits.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserFile", Storage="_UserFiles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserFile> UserFiles
		{
			get
			{
				return this._UserFiles;
			}
			set
			{
				this._UserFiles.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_UserActivits(UserActivit entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserActivits(UserActivit entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_UserFiles(UserFile entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserFiles(UserFile entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserActivit")]
	public partial class UserActivit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _Activity;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnActivityChanging(string value);
    partial void OnActivityChanged();
    #endregion
		
		public UserActivit()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Char(10)")]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activity", DbType="NChar(200)")]
		public string Activity
		{
			get
			{
				return this._Activity;
			}
			set
			{
				if ((this._Activity != value))
				{
					this.OnActivityChanging(value);
					this.SendPropertyChanging();
					this._Activity = value;
					this.SendPropertyChanged("Activity");
					this.OnActivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserActivit", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserActivits.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserActivits.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserFile")]
	public partial class UserFile : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _TableName;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnTableNameChanging(string value);
    partial void OnTableNameChanged();
    #endregion
		
		public UserFile()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Char(10)")]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TableName", DbType="NChar(100)")]
		public string TableName
		{
			get
			{
				return this._TableName;
			}
			set
			{
				if ((this._TableName != value))
				{
					this.OnTableNameChanging(value);
					this.SendPropertyChanging();
					this._TableName = value;
					this.SendPropertyChanged("TableName");
					this.OnTableNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserFile", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserFiles.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserFiles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
