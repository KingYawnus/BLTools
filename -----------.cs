using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using _0086_0086_0086_000D_000A_0086_0086_0086_0086_0094_0088;
using Alphaleonis.Win32.Filesystem;
using Extreme.Net;

internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_008A();
internal delegate Process _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_008D();
internal delegate DateTime _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_008F();
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_0091(int _0020);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_0093(ref DateTime, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_0095();
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_0097(string, string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_009A(object);
internal delegate WindowsIdentity _0086_0086_0086_000D_000A_0086_0086_0086_0088_008F_009D();
internal delegate bool _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0086(object, WindowsBuiltInRole);
internal delegate bool _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0088(string);
internal delegate DirectoryInfo _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_008A(string);
internal delegate string[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_008C(string);
internal delegate bool _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_008E(object, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0090(string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0092(string, string, string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0094(string, string, bool);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0097(object, string _0020, string _0020);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_0099(string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_009B(ref double, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0090_009D(object, string, string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0086(object, string);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0089(string, IFormatProvider);
internal delegate bool? _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_008C(object);
internal delegate string[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_008F(string, string, SearchOption);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0091(string, bool);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0094(ref int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0096(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_0098(string, string);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_009A(object);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_009C(object, string, int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0091_009E(object, int, int);
internal delegate DateTime _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0087(ref DateTime, double);
internal delegate DateTime _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0089(ref DateTime);
internal delegate DateTime _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_008B(string, IFormatProvider);
internal delegate TimeSpan _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_008D(DateTime, DateTime);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_008F(ref TimeSpan);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0091(double);
internal delegate Encoding _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0093(string);
internal delegate byte[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0095(object, string);
internal delegate byte[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0097(Encoding, Encoding, byte[]);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_0099(object, byte[]);
internal delegate Encoding _0086_0086_0086_000D_000A_0086_0086_0086_0088_0092_009B();
internal delegate byte[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0086(object, byte[]);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0088(ref byte, string);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_008A(int, int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_008C(object, int, char);
internal delegate char _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_008E(object, int);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0090(char);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0092(object, int);
internal delegate StringBuilder _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0094(object, char);
internal delegate MD5 _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_0097();
internal delegate StringBuilder _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_009A(object, string);
internal delegate bool _0086_0086_0086_000D_000A_0086_0086_0086_0088_0093_009D(string, string);
internal delegate Dispatcher _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_0086(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_0088(object, ref bool);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_008B(string _0020, string _0020, string _0020, int _0020);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_008D(object);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_008F(object, int, int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0094_0091(object, string _0020, string _0020, string _0020, string _0020, string _0020, string _0020);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0095_008D(object, string _0020, string _0020, string _0020, string _0020, string _0020, string _0020);
internal delegate short _0086_0086_0086_000D_000A_0086_0086_0086_0088_0095_009A(double);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0095_009C(double, double);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0095_009E(double);
internal delegate short _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0087(int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0089(ref short);
internal delegate string[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_008B(object, char[]);
internal delegate HttpProxyClient _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_008D(string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0091(object, ProxyClient);
internal delegate Socks4ProxyClient _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0093(string);
internal delegate Socks5ProxyClient _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0095(string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_0097(object, int);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_009A(object, CookieDictionary);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_009C(object, SslProtocols);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_0096_009E(object, bool);
internal delegate HttpRequest _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_0089(object, string, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_008C(string[]);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_008E(object, string _0020);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_0090(ref double);
internal delegate CookieDictionary _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_0092(object);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_0094(string, string, string, string);
internal delegate HttpResponse _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_0096(object, string, RequestParams);
internal delegate string[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_009A(string, string, string, StringComparison);
internal delegate CultureInfo _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_009C();
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_0097_009E(string, NumberStyles, IFormatProvider);
internal delegate DispatcherOperation _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_0088(object, Delegate, object[]);
internal delegate HttpExceptionStatus _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_008B(object);
internal delegate bool _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_008D(object);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_008F(object, string _0020);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_0091(string);
internal delegate HttpRequest _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_0093(object, HttpHeader, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_0095(string, string[]);
internal delegate HttpResponse _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_0098(object, string, string, string);
internal delegate long _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_009A(string);
internal delegate DateTimeOffset _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_009C(long);
internal delegate DateTime _0086_0086_0086_000D_000A_0086_0086_0086_0088_0098_009E(ref DateTimeOffset);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_0087(ref DateTime);
internal delegate StringComparer _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_008B();
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_008D(string, IEnumerable<string>);
internal delegate DateTimeOffset _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_0091();
internal delegate long _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_0093(ref DateTimeOffset);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_0096(ref long);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_0099(object, int);
internal delegate HttpRequest _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_009B(object, string, object);
internal delegate string[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_0099_009E(object, string[], StringSplitOptions);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0087(object, Cookie);
internal delegate WebRequest _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0089(Uri);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_008B(object, CookieContainer);
internal delegate WebHeaderCollection _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0091(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0093(object, HttpRequestHeader, string);
internal delegate WebResponse _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0096(object);
internal delegate Stream _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_0098(object);
internal delegate WebRequest _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_009B(string);
internal delegate MessageBoxResult _0086_0086_0086_000D_000A_0086_0086_0086_0088_009A_009E(string, string, MessageBoxButton, MessageBoxImage);
internal delegate Process[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_008D();
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_0093(string);
internal delegate Process _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_0096(string);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_0098(string, string, CompressionLevel, bool);
internal delegate double _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_009A(object);
internal delegate byte[] _0086_0086_0086_000D_000A_0086_0086_0086_0088_009B_009E();
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_0087(string, byte[]);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_008C(object, object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_008E(object, double);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_0092(object, Visibility);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_0097(object, bool?);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_0099(_0086_0086_0086_000D_000A_0086_0086_0086_0086_0094_0087._0086_0086_0086_000D_000A_0086_0086_0086_0087_009C_008B _0020);
internal delegate Color _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_009B();
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009C_009D(object, Brush);
internal delegate ItemCollection _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_0089(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_008B(object, int, object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_008F(object, Uri);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_0091(object, EventHandler);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_0094(object, RoutedEventHandler);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_0097(object, TextChangedEventHandler);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_0099(object, MouseButtonEventHandler);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_009B(object, object _0020, RoutedEventArgs _0020);
internal delegate Thread _0086_0086_0086_000D_000A_0086_0086_0086_0088_009D_009D();
internal delegate Delegate _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_0088(Delegate, Delegate);
internal delegate object _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_008B(ref DependencyPropertyChangedEventArgs);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_008D(object, MouseWheelEventHandler);
internal delegate ModifierKeys _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_0090();
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_0096(object, DependencyProperty, object);
internal delegate object _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_0098(object, DependencyProperty);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_009A(DependencyObject);
internal delegate DependencyObject _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_009C(DependencyObject, int);
internal delegate Type _0086_0086_0086_000D_000A_0086_0086_0086_0088_009E_009E(RuntimeTypeHandle);
internal delegate DependencyProperty _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_0087(string, Type, Type, PropertyMetadata);
internal delegate object _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_0089(object);
internal delegate Window _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_008B(DependencyObject);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_008D(object, Window _0020);
internal delegate WindowState _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_0092(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0086_0094(object, WindowState);
internal delegate Application _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_0086();
internal delegate ResourceDictionary _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_0088(object);
internal delegate Collection<ResourceDictionary> _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_008A(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_008C(object, Uri);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_008E(ResourceDictionary _0020);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_0092(Uri _0020);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0087_0098(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_0088_0094(object);
internal delegate DirectoryInfo _0086_0086_0086_000D_000A_0086_0086_0086_0089_0089_0086(string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_0089_008F(object, string _0020, string _0020, string _0020, string _0020, string _0020);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_008A_008B(object, string _0020, string _0020, string _0020, string _0020, string _0020, string _0020, string _0020);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_008A_0094(object, string _0020, string _0020, string _0020, string _0020);
internal delegate MatchCollection _0086_0086_0086_000D_000A_0086_0086_0086_0089_008B_0090(string, string, RegexOptions);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_008B_0097(object);
internal delegate ManagementObjectCollection _0086_0086_0086_000D_000A_0086_0086_0086_0089_008B_009E(object);
internal delegate ManagementBaseObject _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0087(object);
internal delegate object _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0089(object, string);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_008B(object);
internal delegate int _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_008E(string, NumberStyles);
internal delegate char _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0090(int);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0092(char);
internal delegate char[] _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0094(object);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0096(Array);
internal delegate string _0086_0086_0086_000D_000A_0086_0086_0086_0089_008C_0098(ref char);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_008E(ref string _0020);
internal delegate Assembly _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_0092(object);
internal delegate ResourceManager _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_0094();
internal delegate object _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_0096(object, string, CultureInfo);
internal delegate SettingsBase _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_0098(SettingsBase);
internal delegate GroupCollection _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_009A(object);
internal delegate Group _0086_0086_0086_000D_000A_0086_0086_0086_0089_008D_009C(object, int);
internal delegate Type _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_0086(object, int);
internal delegate FieldInfo[] _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_0088(object);
internal delegate MethodBase _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_008B(object, int);
internal delegate Delegate _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_008D(Type, MethodInfo);
internal delegate void _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_008F(object, object, object);
internal delegate Module _0086_0086_0086_000D_000A_0086_0086_0086_0089_008E_0091(object);
