var path = require("path");

var config = {
  entry: [
    "babel-polyfill",
    "./Scripts/index"
  ],
  output: {
    publicPath: "/js/",
    path: path.join(__dirname, "./Content/new/js"),
    filename: "pitch.js",
    library: 'Realtair'
  },
  module: {
    loaders: [
      {
        test: /\.js$/,
        loader: 'babel-loader',
        exclude: /node_modules/,
        query: {
          presets: ['es2015', 'react'],
          plugins: ['transform-decorators-legacy', 'transform-class-properties', 'transform-object-rest-spread']
        }
      },
      {
        test: /\.jsx$/,
        loader: 'babel-loader',
        exclude: /node_modules/,
        query: {
          presets: ['es2015', 'react'],
          plugins: ['transform-decorators-legacy', 'transform-class-properties', 'transform-object-rest-spread']
        }
      },
      {
        test: /\.css$/,
        use: ["style-loader", "css-loader"]
      },
      {
        test: /\.(pdf|jpg|png|gif|svg|ico)$/,
        use: [
          {
            loader: 'url-loader'
          },
        ]
      }
    ]
  },
  resolve: {
    extensions: ['.js', '.jsx'],
  }
};

module.exports = config;