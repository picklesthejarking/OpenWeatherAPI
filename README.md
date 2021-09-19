<h1 align="center">OpenWeather API</h1>
<div align="center">
<img alt="GitHub issues" src="https://img.shields.io/github/issues/picklesthejarking/OpenWeatherAPI?style=for-the-badge">
<img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/picklesthejarking/OpenWeatherAPI?include_prereleases&label=Version&style=for-the-badge">
<img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/picklesthejarking/OpenWeatherAPI?style=for-the-badge">
<img alt="GitHub" src="https://img.shields.io/github/license/picklesthejarking/OpenWeatherAPI?style=for-the-badge">
</div>
<h3 align="center">A C# Class Library which enables you to integrate the OpenWeather API into your project.</h3>
<p align="center"><img src="/docres/orange-divider.svg" /></p>

## 📖 Table of Contents
<ul>
  <li>
    <a href="#Installation">Setup &amp; Installation</a>
  </li>
  <li>
    <a href="#Usage">Usage</a>
    <ul>
      <li>
        <a href="#Usage-CurrentWeather">Current Weather</a>
      </li>
    </ul>
  </li>
  <li>
    <a href="#Appendix">Appendix</a>
    <ul>
      <li>
        <a href="#Appendix-CityIDs">City ID's</a>
      </li>
    </ul>
  </li>
</ul>

<p align="center"><img src="/docres/orange-divider.svg" /></p>

<h2 id="Installation">Setup &amp; Installation</h2>
<p>You will need an API key for the OpenWeather API details of the API can be find here: <a href="https://openweathermap.org/api" target="_blank">https://openweathermap.org/api</a>. Once you have the API Key, install the Nuget package PTJK.OpenWeatherAPI.</p>
<br/>
<h2 id="Usage">Usage</h2>
<p>Firstly, create a client to use the API.</p>

```CSharp
var client = new PTJK.OpenWeatherAPI.Client("YOUR_API_KEY_HERE");
```

<p>Then use the client to retrieve weather information.</p>

```CSharp
var currentWeather = client.CurrentWeather.GetByName("London").Result;
```

<p>You can also make the call asynchronously as well.</p>

```CSharp
var currentWeather = await client.CurrentWeather.GetByName("London");
```
<br/>
<h3 id="Usage-CurrentWeather">client.CurrentWeather</h3>
<p>The current weather class is able to get the current weather by a given location. The location can be specified by city name, city id (see Appendix City ID), or geographic coordinates (latitude and longitude).</p>

<br/>
<h2 id="Appendix">Appendix</h2>
<h3 id="Appendix-CityIDs">City ID's</h3>

