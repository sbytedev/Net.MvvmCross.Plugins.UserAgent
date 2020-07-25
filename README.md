# MvvmCross UserAgent Plugin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.MvvmCross.Plugins.UserAgent.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.MvvmCross.Plugins.UserAgent.svg)
[![Build Status](https://img.shields.io/bitrise/8d14360844287246/develop?label=development&token=2GgXyMq4BE2Y7gURgeivIg&branch)](https://app.bitrise.io/app/d1fd3128deec4532)
[![Build Status](https://img.shields.io/bitrise/8d14360844287246/master?label=production&token=2GgXyMq4BE2Y7gURgeivIg&branch)](https://app.bitrise.io/app/d1fd3128deec4532)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.mvvmcross.plugins.useragent/badge)](https://www.codefactor.io/repository/github/sbytedev/net.mvvmcross.plugins.useragent)

Provides a cross-platform functionality to get the current [User-Agent](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/User-Agent) value.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.MvvmCross.Plugins.UserAgent
```

## Usage
```cs
using SByteDev.MvvmCross.Plugins.UserAgent;

var userAgent = await Mvx.IoCProvider.Resolve<IMvxUserAgent>().GetUserAgentAsync(CancellationToken.None);
```

## Implementation
Based on [Xamarin UserAgent Plugin](https://github.com/SByteDev/Net.Xamarin.Plugins.UserAgent).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
