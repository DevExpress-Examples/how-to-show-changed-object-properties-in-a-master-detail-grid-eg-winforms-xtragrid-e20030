﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo

Namespace WindowsFormsApplication25

	Public Class DomainObject
		Inherits BaseObject

		Public Sub New(ByVal s As Session)
			MyBase.New(s)
		End Sub

		<Key(True), Persistent("Oid")> _
		Private _Oid As Guid
		<PersistentAlias("_Oid")> _
		Public ReadOnly Property Oid() As Guid
			Get
				Return _Oid
			End Get
		End Property

		Private _IntProperty As Integer
		Public Property IntProperty() As Integer
			Get
				Return _IntProperty
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("IntProperty", _IntProperty, value)
			End Set
		End Property
		Private _DateTimeProperty As DateTime
		Public Property DateTimeProperty() As DateTime
			Get
				Return _DateTimeProperty
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("DateTimeProperty", _DateTimeProperty, value)
			End Set
		End Property
		Private _DecimalProperty As Decimal
		Public Property DecimalProperty() As Decimal
			Get
				Return _DecimalProperty
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue("DecimalProperty", _DecimalProperty, value)
			End Set
		End Property
		Private _StringProperty As String
		Public Property StringProperty() As String
			Get
				Return _StringProperty
			End Get
			Set(ByVal value As String)
				SetPropertyValue("StringProperty", _StringProperty, value)
			End Set
		End Property
	End Class
End Namespace
