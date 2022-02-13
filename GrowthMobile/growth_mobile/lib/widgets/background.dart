import 'package:flutter/material.dart';

class Background extends StatelessWidget {
  const Background({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
        body: Image(image: AssetImage('assets/images/water.jpg')));
    //return const Image(image: AssetImage('assets/images/water.jpg'));
  }
}
