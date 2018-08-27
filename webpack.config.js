var CONFIG = {
  fsharpEntry: "./src/fableconf.fsproj",
  outputDir: "./public",
  assetsDir: "./public",
  devServerPort: 8080,
  // Use babel-preset-env to generate JS compatible with most-used browsers.
  // More info at https://babeljs.io/docs/en/next/babel-preset-env.html
  babel: {
      presets: [
          ["env", {
              "modules": false,
              "useBuiltIns": true,
          }]
      ],
  }
}

// If we're running the webpack-dev-server, assume we're in development mode
var isProduction = !process.argv.find(v => v.indexOf('webpack-dev-server') !== -1);
console.log("Bundling for " + (isProduction ? "production" : "development") + "...");

var path = require("path");
var webpack = require("webpack");

module.exports = {
  devtool: "source-map",
  entry: CONFIG.fsharpEntry,
  output: {
    path: path.join(__dirname, CONFIG.outputDir),
    filename: 'bundle.js',
  },
  mode: isProduction ? "production" : "development",
  devtool: isProduction ? "source-map" : "eval-source-map",
  plugins: isProduction ? [] : [
      new webpack.HotModuleReplacementPlugin(),
  ],
  devServer: {
    publicPath: "/",
    contentBase: CONFIG.assetsDir,
    port: CONFIG.devServerPort,
    proxy: CONFIG.devServerProxy,
    hot: true,
    inline: true
  },
  module: {
    rules: [
      {
        test: /\.fs(x|proj)?$/,
        use: "fable-loader"
      },
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
          options: CONFIG.babelOptions
        },
      },
      {
        test: /\.sass$/,
        use: [
          "style-loader",
          "css-loader?url=false",
          "sass-loader"
        ]
      }
    ]
  }
};
